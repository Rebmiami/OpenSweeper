using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace OpenSweeper
{
	public static class ImageLoader
	{
		public static Texture2D LoadTexture(string path, GraphicsDevice device)
		{
			Texture2D texture;
			using (var filestream = new FileStream(path, FileMode.Open))
			{
				texture = Texture2D.FromStream(device, filestream);
			}

			return texture;
		}
	}
}
