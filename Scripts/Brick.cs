using Godot;
using System;

public partial class Brick : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("r");
	}
	public void OnBodyEntered(PhysicsBody2D body)
	{
		QueueFree();
	}
}
