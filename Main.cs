using Godot;
using System;

public partial class Main : Node
{
	// Called when the node enters the scene tree for the first time.

	public void NewGame()
	{
		ResetBall();
		GetNode<Ball>("Ball").Velocity = new Vector2(GD.Randf(), -1);
	}
	public void ResetBall()
	{
		Marker2D ballStartingPosition = GetNode<Marker2D>("BallStartingPosition");
		GetNode<Ball>("Ball").Position = ballStartingPosition.Position;
	}

	public override void _Ready()
	{
		NewGame();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
