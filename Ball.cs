using Godot;
using System;

public partial class Ball : RigidBody2D
{
	public Vector2 Velocity { get; set; } = Vector2.Zero;
	public int Speed { get; } = 600;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position += Velocity * Speed * (float)delta;
	}
}
