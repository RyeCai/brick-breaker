using Godot;
using System;

public partial class Paddle : Area2D
{
	[Export]
	public int Speed { get; set; } = 500;

	public Vector2 ScreenSize;
	private float MinXPosition;
	private float MaxXPosition;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
		CapsuleShape2D paddleCapsuleShape2D = (CapsuleShape2D)GetNode<CollisionShape2D>("CollisionShape2D").Shape;
		MinXPosition = paddleCapsuleShape2D.Height / 2;
		MaxXPosition = ScreenSize.X - paddleCapsuleShape2D.Height / 2;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 velocity = Vector2.Zero;

		if (Input.IsActionPressed("move_right"))
		{
			velocity.X += 1;
		}

		if (Input.IsActionPressed("move_left"))
		{
			velocity.X -= 1;
		}

		Position += velocity * Speed * (float)delta;
		Position = new Vector2(x: Mathf.Clamp(Position.X, MinXPosition, MaxXPosition), y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y));
	}
}
