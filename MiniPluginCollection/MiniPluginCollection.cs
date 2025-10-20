using ECommons.Automation.NeoTaskManager;
using ECommons.Logging;
using MiniPluginCollection.Config;
using MiniPluginCollection.IPC;
using MiniPluginCollection.Scheduler;
using MiniPluginCollection.Ui;
using MiniPluginCollection.Ui.MainWindow;
using Pictomancy;

namespace MiniPluginCollection;

public sealed class MiniPluginCollection : IDalamudPlugin
{
    public string Name => "MiniPluginCollection";

    private static PluginConfig? Config;
    public static PluginConfig C => Config ??= LoadConfig<PluginConfig>();

    private static T LoadConfig<T>() where T : IYamlConfig, new()
    {
        var path = typeof(T).GetProperty("ConfigPath")!.GetValue(null)!.ToString()!;
        var config = YamlConfig.Load<T>(path);

        if (config == null)
        {
            // PluginLog.Warning($"[{typeof(T).Name}] Config was null. Creating new default.");
            config = new T();
            YamlConfig.Save(config, path);
        }

        // PluginLog.Information($"[{typeof(T).Name}] Loaded from {path}");
        return config;
    }

    internal static MiniPluginCollection P = null!;

    // Window Systems for the plugin (nice and neatly)
    internal WindowSystem windowSystem;
    internal MainWindow mainWindow;
    internal DebugWindow debugWindow;

    // Taskmanager from Ecommons (bless)
    internal TaskManager taskManager;

    // Internal IPC's from other plugins
    internal LifestreamIPC lifestream;
    internal NavmeshIPC navmesh;

    public MiniPluginCollection(IDalamudPluginInterface pi)
    {
        P = this;
        ECommonsMain.Init(pi, P, ECommons.Module.DalamudReflector, ECommons.Module.ObjectFunctions, Module.SplatoonAPI);

        PictoService.Initialize(pi);

        //IPC's that are used
        taskManager = new();
        lifestream = new();
        navmesh = new();

        // all the windows
        windowSystem = new();
        mainWindow = new();
        debugWindow = new();

        Svc.PluginInterface.UiBuilder.Draw += windowSystem.Draw;
        Svc.PluginInterface.UiBuilder.OpenMainUi += () =>
        {
            mainWindow.IsOpen = true;
        };
        /* 
        Svc.PluginInterface.UiBuilder.OpenConfigUi += () =>
        {
            
        }; 
        */
        EzCmd.Add("/IcesPluginCollection", OnCommand, """
            Open plugin interface
            /ipc - alias for plugin
            """);
        EzCmd.Add("/ipc", OnCommand);

        taskManager = new(new(abortOnTimeout: true, timeLimitMS: 20000, showDebug: true));

        Init();
        Svc.Framework.Update += Tick;
    }

    public void Init()
    {
        
    }

    private void Tick(object _)
    {
        if (Svc.ClientState.LocalPlayer != null)
        {
            SchedulerMain.Tick();
        }
        else
        {
            SchedulerMain.DisablePlugin();
        }
    }

    public void Dispose()
    {
        Safe(() => Svc.Framework.Update -= Tick);
        Safe(() => Svc.PluginInterface.UiBuilder.Draw -= windowSystem.Draw);
        ECommonsMain.Dispose();
        PictoService.Dispose();
    }

    private void OnCommand(string command, string args)
    {
        if (args.EqualsIgnoreCaseAny("d", "debug"))
        {
            debugWindow.IsOpen = !debugWindow.IsOpen;
        }
        else if (args.EqualsIgnoreCaseAny("s", "settings"))
        {
            
        }
        else
        {
            mainWindow.IsOpen = !mainWindow.IsOpen;
        }
    }
}
