using Godot;
using System;

public partial class Hand : Control
{
	[Export]
	public PackedScene cardScene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AddCard();
	}

	public void AddCard()
	{
		var instance = cardScene.Instantiate();
		AddChild(instance);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
