// met using kan je een XNA codebibliotheek gebruiken in je class 
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidePanic
{
    public class image
    {
        // fields
        // maak een variabele (reference) aan van het type texture2D met de naam texture 
        private Texture2D texture;

        // maak een variabele (reference) aan van het type Color met de naam color 
        private Color color = Color.White;

        //maak een rectangle voor het detecteren van collisions 
        private Rectangle rectangle;

        private PyramidePanic game;

        #region properties
        //properties
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }

        } 
        #endregion

        //Constructor
        public image(PyramidePanic game, string pathnameAsset, Vector2 position)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(pathnameAsset);
            this.rectangle = new Rectangle((int)position.X,
                                           (int)position.Y,
                                           this.texture.Width,
                                           this.texture.Height);

        }

        //update

        //draw
        public void Draw(GameTime gameTime)
        {
            this.game.Spritebatch.Draw(this.texture, this.rectangle, this.color);

        }
        //helper methods
    }
}
