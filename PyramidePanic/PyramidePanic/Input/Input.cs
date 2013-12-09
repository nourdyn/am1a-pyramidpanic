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
    public static class Input
    {
        //fields
        private static KeyboardState ks, oks;
        private static MouseState ms, oms;

        // dit is een rectangle die aan de cursor van de zit vastgeplakt 

        private static Rectangle mouseRect;
        //constructor
        static Input()
        {
           
            ms = Mouse.GetState();
            oks = ks;
            ks = Keyboard.GetState();
            oms = ms;
            mouseRect = new Rectangle(ms.X, ms.Y, 1, 1);
        }

        //update
        public static void Update()
        {
            ms = Mouse.GetState();
            oms = ms;
            oks = ks;
            ks = Keyboard.GetState();
        }

        // dit is een edgedetector voor het indrukken van een toets
        public static bool EdgeDetectKeyDown(Keys key)
        {
            return (ks.IsKeyDown(key) && oks.IsKeyUp(key));
            
        }

        public static bool EdgeDetectMousePressLeft()
        {
            return ((ms.LeftButton == ButtonState.Pressed) && (oms.LeftButton == ButtonState.Released ));
        }


        public static bool LevelDetectKeyDown(Keys key)
        {

            return (ks.IsKeyDown(key));


        }

        public static bool LevelDetectKeyUp(Keys key)
        {

            return (ks.IsKeyUp(key));
        }

        public static Vector2 MousePosition()
        {
            return new Vector2(ms.X, ms.Y);

        }

        public static Rectangle MouseRect()
        {
            mouseRect.X = ms.X;
            mouseRect.Y = ms.Y;
            return mouseRect;
        }
        
    }
}
