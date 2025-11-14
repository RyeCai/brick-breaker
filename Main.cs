using Godot;
using System;

public partial class Main : Node
{
	// Called when the node enters the scene tree for the first time.
	public void NewGame()
	{
		ResetBall();
	}
	public void ResetBall()
	{
		Marker2D ballStartingPosition = GetNode<Marker2D>("BallStartingPosition");
		GetNode<Ball>("Ball").Position = ballStartingPosition.Position;
		//GetNode<Ball>("Ball").Launched = true;
	}

	public override void _Ready()
	{
		NewGame();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("launch_ball"))
		{
			GetNode<Ball>("Ball").LinearVelocity = new Vector2(GD.Randf(), -1) * GetNode<Ball>("Ball").Speed;
			GetNode<Ball>("Ball").Launched = true;
		}
	}
}
