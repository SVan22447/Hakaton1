using Godot;
using System;

public partial class tutorial : Node2D{
	private void SelectNext(){
		GetTree().ChangeSceneToFile("res://Scenes/select.tscn");
	}
}
