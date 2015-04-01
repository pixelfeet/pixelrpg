using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PixelRPG.Menu
{
    class Panel
    {
        private Rectangle _dimensions;
        private Texture2D _texture;

        public Rectangle dimensions
        {
            get { return _dimensions; }
            set { _dimensions = value; }
        }

        public Panel(Rectangle dimensions)
        {
            this.dimensions = dimensions;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _dimensions, Color.White);
        }
    }
}
