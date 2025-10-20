namespace IceBoxofeXtras.Ui;

internal class MainWindow : Window
{
    public MainWindow() :
        base($"Ice's Plugin Collection {P.GetType().Assembly.GetName().Version} ###IPC_MainWindow")
    {
        Flags = ImGuiWindowFlags.None;
        SizeConstraints = new()
        {
            MinimumSize = new Vector2(300, 300),
            MaximumSize = new Vector2(2000, 2000)
        };
        P.windowSystem.AddWindow(this);
        AllowPinning = true;
    }

    public void Dispose() { }

    public override void Draw()
    {
      
    }
}
