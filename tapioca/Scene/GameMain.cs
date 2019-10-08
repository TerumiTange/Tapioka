using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using tapioca.Device;
using tapioca.Actor;

namespace tapioca.Scene
{
    class GameMain:IScene
    {
        bool isEndFlag;
        private Player Player;

        public GameMain()
        {

        }

        public void Initialize()
        {
            Player = new Player();
            Player.Initialize();
        }

        public void Draw(Renderer renderer)
        {
            renderer.Begin();

            renderer.End();
        }

        public bool IsEnd()
        {
            return isEndFlag;
        }

        public Scene Next()
        {
            return Scene.Title;
        }
        public void Shutdown()
        {

        }

        public void Update(GameTime gameTime)
        {
            Player.Update(gameTime);
        }
    }
}
