using Godot;
using System;

public partial class Menu : Node2D{
	private void TutorNext(){
		GD.Print("test");
		GetTree().ChangeSceneToFile("res://Scenes/tutorial.tscn");
	}

}
