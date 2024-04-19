using Godot;
using System;

public partial class Respawn : Area2D
{
	private void RespawnM(Node2D body){
		body.GlobalPosition =GetNode<Marker2D>("Marker2D").GlobalPosition;

	}
}
