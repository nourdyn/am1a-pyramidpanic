﻿// met using kan je een XNA codebibliotheek gebruiken in je class 
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
    public interface IState
    {

        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);
    }
}
