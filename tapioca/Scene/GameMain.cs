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
<<<<<<< HEAD
        private Player Player;
=======
        private Sound sound;
>>>>>>> origin/Aluse

        public GameMain()
        {
            var gameDevice = GameDevice.Instance();
            sound = gameDevice.GetSound();
        }

        public void Initialize()
        {
<<<<<<< HEAD
            Player = new Player();
            Player.Initialize();
=======
            isEndFlag = false;
>>>>>>> origin/Aluse
        }

        public void Draw(Renderer renderer)
        {
            renderer.Begin();
<<<<<<< HEAD

=======
            renderer.DrawTexture("dami3", Vector2.Zero);
>>>>>>> origin/Aluse
            renderer.End();
        }

        public bool IsEnd()
        {
            return isEndFlag;
        }

        public Scene Next()
        {
            return Scene.Ending;
        }
        public void Shutdown()
        {
            sound.StopBGM();
        }

        public void Update(GameTime gameTime)
        {
<<<<<<< HEAD
            Player.Update(gameTime);
=======
            if (Input.GetKeyTrigger(Keys.Z))
            {
                isEndFlag = true;
            }
>>>>>>> origin/Aluse
        }
    }
}
