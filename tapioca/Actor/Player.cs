using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tapioca.Device;
using Microsoft.Xna.Framework.Input;

using tapioca.Utility;

namespace tapioca.Actor
{
    class Player
    {
        public bool drinkFlag;//飲めるかどうか
        public bool eatFlag;//食べれるかどうか
        public int tapiocaCount;//タピオカが何個あるか

        public Player()
        {

        }

        public void Initialize()
        {
            tapiocaCount = 0;
            drinkFlag = true;
            eatFlag = false;
        }

        public void Draw(Renderer renderer)
        {

        }

        public void Update(GameTime gameTime)
        {
            
            Drink();
            Eat();EatStart();
            EatStop();
        }

        public void Drink()
        {
            if (!drinkFlag) return;
            if (Input.GetKeyState(Keys.Space))
            {
                Console.WriteLine("たぴおかおいしー");
            }
        }
        public void Eat()
        {
            if (!eatFlag) return;
            if (Input.GetKeyTrigger(Keys.Space))
            {
                tapiocaCount--;
            }
        }

        public void Count(int tapioka)//タピオカの個数
        {
            tapiocaCount = tapioka;
        }

        public void EatStart()
        {
            if (eatFlag) return;//食べないといけないならreturn
            if (tapiocaCount < 5) return;//タピオカが5個以下ならreturn
            eatFlag = true;
            drinkFlag = false;
        }

        public void EatStop()//食べ終わったら
        {
            if (!eatFlag) return;
            if (tapiocaCount > 0) return;
            tapiocaCount = 0;
            eatFlag = false;
            drinkFlag = true;
        }
    }
}
