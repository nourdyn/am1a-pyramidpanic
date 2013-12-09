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
    public class GameOverScene : IState
    {

        private PyramidePanic game;


        // contructor van de StartScene Class
        public GameOverScene(PyramidePanic game)
        {
            this.game = game;
        }
        // initialize methode. deze methode initialiseert (geeft startwaarden aan variabelen)
        // void wil zeggen dat er niets teruggeven wordt.
        public void initialize()
        {


        }

        // loadcontent methode. deze methoden maakt nieuwe objecten aaan van de verschillende
        //classes
        public void LoadContent()
        {


        }

        
        //update methode. deze methode word normaal 60 maal per seconde aangeroepen.
        // en update alle variabelen, methods enz........
        public void Update(GameTime gametime)
        {
            if (Input.EdgeDetectKeyDown(Keys.B))
            {
                this.game.IState = this.game.HelpScene;
            }


        }
        // draw methiden. deze methoden wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures op het canvas
        public void Draw(GameTime gametime)
        {

            this.game.GraphicsDevice.Clear(Color.LightPink);
        }

    }
}
