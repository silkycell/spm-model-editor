using Godot;
using Rainbow.ImgLib.Formats.Implementation;
using System;
using System.IO;

public partial class TPLInterfacer : Node
{
	public Texture2D[] Textures;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		String TexturePath = "C:\\Users\\Aimee\\Documents\\Godot Projects\\spm-model-editor\\e_2D_manera-";
		TPLTextureSerializer serializer = new();
		TPLTexture tpl = (TPLTexture)serializer.Open(File.OpenRead(TexturePath));

		GD.Print("ghjdfg");

		// Textures = new Texture2D[];
		/*for (int i = 0; i < Textures.Length; i++)
		{
			
			
		}*/
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
