

namespace MiniPluginCollection.Ui;

internal class DebugWindow : Window
{
    public DebugWindow() : base ($"Explorer's IceBox Debug ###Explorer's Icebox Debug")
    {
        Flags = ImGuiWindowFlags.None;
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(100, 100),
        };
        P.windowSystem.AddWindow(this);
    }

    public void Dispose()
    {
        P.windowSystem.RemoveWindow(this);
    }

    // variables that hold the "ref"s for ImGui
    private string addonName = "default";
    private string inputValue = "0"; // The uint value to be edited
    private static ulong Result;

    private string[] debugTypes = ["Player Info", "Navmesh Debug", "Misc Info", "Route Sell", "Target Info", "Imgui Testing", "Island Node Finder", "Island Item Info", "Route Editor V4", "Simple Route Creator", "Picto Testing"];
    int selectedDebugIndex = 0; // This should be stored somewhere persistent

    public override void Draw()
    {
        float spacing = 10f;
        float leftPanelWidth = 200f;
        float rightPanelWidth = ImGui.GetContentRegionAvail().X - leftPanelWidth - spacing;
        float childHeight = ImGui.GetContentRegionAvail().Y;

        if (ImGui.BeginChild("DebugSelector", new System.Numerics.Vector2(leftPanelWidth, childHeight), true))
        {
            for (int i = 0; i < debugTypes.Length; i++)
            {
                bool isSelected = (selectedDebugIndex == i);
                string label = isSelected ? $"→ {debugTypes[i]}" : $"   {debugTypes[i]}"; // Add space for alignment

                if (ImGui.Selectable(label, isSelected))
                {
                    selectedDebugIndex = i;
                }
            }
            ImGui.EndChild();
        }

        ImGui.SameLine(0, spacing);

        if (ImGui.BeginChild("DebugContent", new System.Numerics.Vector2(rightPanelWidth, childHeight), true))
        {
            switch (selectedDebugIndex)
            {
                default: ImGui.Text("Unknown Debug View"); break;
            }

            ImGui.EndChild();
        }
    }
}
