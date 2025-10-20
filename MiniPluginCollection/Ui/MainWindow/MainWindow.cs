

namespace MiniPluginCollection.Ui.MainWindow;

internal class MainWindow : Window
{
    public MainWindow() :
        base($"Explorer's Icebox {P.GetType().Assembly.GetName().Version} ###Explorer'sIceboxMainWindow")
    {
        Flags = ImGuiWindowFlags.None;
        SizeConstraints = new()
        {
            MinimumSize = new Vector2(300, 300),
            MaximumSize = new Vector2(2000, 2000)
        };
        P.windowSystem.AddWindow(this);
        AllowPinning = false;
    }

    public void Dispose() { }

    public override void Draw()
    {

    }
}
