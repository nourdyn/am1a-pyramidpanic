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
        // maak een enumeration voor de buttons die op het scherm 
        private enum Buttons { Start, Load, Help, Score, Quit}
        
        // maak een variabele van het type buttons en geef hem de waar buttons.start
        private Buttons buttonActive = Buttons.Start;

        private image start;
        // maak een variabele van het type pyramidpanic 
        private PyramidePanic game;
        private image load;
        private image help;
        private image score;
        private image quit;

        private List<image> buttonlist;
        private Color activeColor = Color.Gold;
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

            this.buttonlist = new List<image>();
            
            this.buttonlist.Add(this.start = new image(this.game, @"StartScene\Button_start", new Vector2(20f, 440f)));
            this.buttonlist.Add(this.load = new image(this.game, @"startscene\Button_load", new Vector2(120f, 440f)));
            this.buttonlist.Add(this.help = new image(this.game, @"startscene\Button_help", new Vector2(250f, 440f)));
            this.buttonlist.Add(this.score = new image(this.game, @"startscene\Button_scores", new Vector2(380f, 440f)));
            this.buttonlist.Add(this.quit = new image(this.game, @"startscene\Button_quit", new Vector2(480f, 440f)));
            this.start.Color = Color.Gold;
        }

        //update
        public void Update(GameTime gameTime)
        {

            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.buttonActive++;
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.buttonActive--;
            }
            // maak een switch case constructie voor de variabelen buttonActive
            switch (this.buttonActive)
            {
                case Buttons.Start:
                    this.start.Color = this.activeColor;
                    break;
                case Buttons.Load:
                    this.load.Color = this.activeColor;

                    break;
                case Buttons.Help:
                    this.help.Color = this.activeColor;
                    break;
                case Buttons.Score:
                    this.help.Color = this.activeColor;
                    break;
                case Buttons.Quit:
                    this.help.Color = this.activeColor;
                    break;


            }

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
