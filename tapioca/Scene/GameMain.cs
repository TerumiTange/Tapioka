using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using tapioca.Device;

namespace tapioca.Scene
{
    class GameMain:IScene
    {
        bool isEndFlag;
        private Sound sound;

        public GameMain()
        {
            var gameDevice = GameDevice.Instance();
            sound = gameDevice.GetSound();
        }

        public void Initialize()
        {
            isEndFlag = false;
        }

        public void Draw(Renderer renderer)
        {
            renderer.Begin();
            renderer.DrawTexture("dami3", Vector2.Zero);
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
            if (Input.GetKeyTrigger(Keys.Z))
            {
                isEndFlag = true;
            }
        }
    }
}
