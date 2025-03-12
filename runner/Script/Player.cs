using Godot;

public partial class Player : Area2D
{
    [Export] public Vector2 Speed = new Vector2(100, 0); // Horizontal speed (100 pixels per second)

    public override void _Process(double delta)
    {

        Position += Speed * (float)delta; // Move the player automatically
    }
}
