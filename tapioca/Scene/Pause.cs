using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using tapioca.Device;
using tapioca.Scene;


namespace tapioca.Scene
{
    class Pause : IScene
    {
        private bool isEnd;
        private Scene next;
        private IScene lastScene;
        private int cnt;
        public void Draw(Renderer renderer)
        {
            lastScene.Draw(renderer);
            renderer.Begin();
            renderer.DrawTexture("pause", new Vector2(0, 0), 0.5f);
            if (cnt < 7)
            {
                renderer.DrawString("Pause", new Vector2(250, 10),
                    Color.OrangeRed, new Vector2(2, 3));
            }
            renderer.End();
        }

        public void Initialize()
        {
            isEnd = false;
            cnt = 0;
        }

        public bool IsEnd()
        {
            throw new NotImplementedException();
        }

        public Scene Next()
        {
            return next;
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            if (Input.GetKeyTrigger(Keys.P))
            {
                isEnd = true;
            }
            cnt++;
            if (cnt > 13)
            {
                cnt = 0;
            }
        }
    }
}
