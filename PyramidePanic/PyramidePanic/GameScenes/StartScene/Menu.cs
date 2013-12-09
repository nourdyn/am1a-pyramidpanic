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
    public class Menu
    {
        // fields
        private image start;
        // maak een variabele van het type pyramidpanic 
        private PyramidePanic game;
        private image load;
        private image help;
        private image score;
        private image quit;

        //constructor
        public Menu (PyramidePanic game)
        {
            this.game = game;
            this.Initialize();

        }

        public void Initialize()
        {
            this.LoadContent();

        }

        public void LoadContent()
        {
            this.start = new image(this.game, @"StartScene\Button_start", new Vector2(20f, 440f));
            this.load = new image(this.game, @"startscene\Button_load", new Vector2(120f, 440f));
            this.help = new image(this.game, @"startscene\Button_help", new Vector2(250f, 440f));
            this.score = new image(this.game, @"startscene\Button_scores", new Vector2(380f, 440f));
            this.quit = new image(this.game, @"startscene\Button_quit", new Vector2(480f, 440f));
        }

        //update
        public void Update(GameTime gameTime)
        {


        }

        //draw
        public void Draw(GameTime gameTime)
        {

            this.start.Draw(gameTime);
            this.load.Draw(gameTime);
            this.help.Draw(gameTime);
            this.score.Draw(gameTime);
            this.quit.Draw(gameTime);
        }


    }
}
