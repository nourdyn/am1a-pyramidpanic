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
    
    public class PyramidePanic : Microsoft.Xna.Framework.Game
    {
        //fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        //maak een variable van de start scene 
        private StartScene startScene;
        private PlayScene playScene;
        private HelpScene helpScene;
        private GameOverScene gameOverScene;

        // maak een variable aan van het type interface IState 
        private IState iState;


        // properties
        // maak de interface variabelen iState beschikbaar buiten de class door middel van een propertie Istate
        public IState IState
        {
            get { return this.iState; }
            set { this.iState = value; }

        }

        #region properties

        // propertie image
        public SpriteBatch Spritebatch

        {
            get { return this.spriteBatch; }
        }

        // propertie startscene
        public StartScene StartScene
        {
            get { return this.startScene; }

        }
        // propertie playscene
        public PlayScene Playscene
        {
            get { return this.playScene; }
        }
        // properties helpscene
        public HelpScene HelpScene
        {
            get { return this.helpScene; }
        }
        // properties GameOverScene
        public GameOverScene GameOverScene
        {
            get { return this.gameOverScene; }

        } 
        #endregion
        // maak het field this.StartScene beschikbaar buiten de class d.m.v een
        // property StartScene 
        // dit is de constructor. heeft altijd dezelfde naam als de class
        public PyramidePanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            // verander de titel van het canvas
            Window.Title = "Pyramid Panic Beta 0.1";

            // maak de muiz zichtbaar 
            IsMouseVisible = true; 
            
            // verandert de breedte van het canvas.
            this.graphics.PreferredBackBufferWidth = 640;
            
            // verandert de hoogte van het canvas.
            this.graphics.PreferredBackBufferHeight = 480;

            
            // past de nieuwe hoogte en breedte toe.
            this.graphics.ApplyChanges();

            base.Initialize();
        }

       
        protected override void LoadContent()
        {
            // een spritebatch is nodig voor het tekenen van textures op het canvas 
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // we maken nu het object/instantie aan van het type startScene. dit doe je door
            // de constructor aan te roepen van de StartScene class.
            this.startScene = new StartScene(this);
            this.playScene = new PlayScene(this);
            this.helpScene = new HelpScene(this);
            this.gameOverScene = new GameOverScene(this);
            this.iState = this.startScene;
          
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)||
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();
            // de update method van de static input class wordt aangeroepen 
            Input.Update();
            // TODO: Add your update logic here
            // roep de update methode aan van de startscene class
            
            this.iState.Update(gameTime);
            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            // geeft de achtegrond een kleur 
            GraphicsDevice.Clear(Color.Yellow);
            // roep de draw methode aan van start scene 
            // voor een spritebatch instantie iets kan tekenen de begin() methode
            this.spriteBatch.Begin();

            // de draw methode van het object dat toegewezen is aan het interface-object
            // this.istat word aangeroepen 
            this.iState.Draw(gameTime);
           
            
            // nadat de spritebatch.draw() is aangeroepen moet de end() methode van
            // de spritebatch class worden aangeroepen 
            this.spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
