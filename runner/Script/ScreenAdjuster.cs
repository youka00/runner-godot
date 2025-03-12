using Godot;

public partial class ScreenAdjuster : Node
{
    public override void _Ready()
    {
        AdjustResolution();
    }

    private void AdjustResolution()
    {
        Vector2 screenSize = GetViewport().GetVisibleRect().Size;
        GD.Print($"Screen Size: {screenSize.X}x{screenSize.Y}");

        float aspectRatio = screenSize.X / screenSize.Y;
        if (aspectRatio > 1.5)
        {
            GD.Print("Widescreen detected.");
        }
        else
        {
            GD.Print("Standard aspect ratio.");
        }
    }
}
