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

        public GameMain()
        {

        }

        public void Initialize()
        {

        }

        public void Draw(Renderer renderer)
        {

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

        }
    }
}
