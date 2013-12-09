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
    public class StartScene : IState // de class StartScene implementeert de interface IState
    {

        private PyramidePanic game;
        private image background;
        private image title;

        private Menu menu;

        //properties
        public StartScene startScene
        {
            get { return this.startScene; }
        }


        // contructor van de StartScene Class
        public StartScene(PyramidePanic game)
        {
            this.game = game;
            this.initialize();
        }
        // initialize methode. deze methode initialiseert (geeft startwaarden aan variabelen)
        // void wil zeggen dat er niets teruggeven wordt.
        public void initialize()
        {
            this.LoadContent();

        }

        // loadcontent methode. deze methoden maakt nieuwe objecten aaan van de verschillende
        //classes
        public void LoadContent()
        {
            // nu maken we een object aan ( instantie ) van de class image
            this.background = new image(this.game,@"StartScene\Background", Vector2.Zero);
            this.title = new image(this.game,@"Startscene\Title",new Vector2(100f, 30f));
            this.menu = new Menu(this.game);

        }
        //update methode. deze methode word normaal 60 maal per seconde aangeroepen.
        // en update alle variabelen, methods enz........
        public void Update(GameTime gametime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.B) || Input.EdgeDetectMousePressLeft())
            {
                this.game.IState = this.game.Playscene;
            }
            
        }
        // draw methiden. deze methoden wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures op het canvas
        public void Draw(GameTime gametime)
        {

            // roep de draw method aan van het background object
            this.game.GraphicsDevice.Clear(Color.Purple);
            this.background.Draw(gametime);

            //roep de draw method aan van het title object
            this.title.Draw(gametime);
            //roep de draw method aan van het menu object 
            this.menu.Draw(gametime);
        }

    }
}
