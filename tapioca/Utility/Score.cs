using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapioca.Utility
{
    class Score
    {
        public int score;
        
        public Score()
        {

        }

        public void Initialize()
        {
            score = 0;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void UpScore(int upScore)
        {
            score += upScore;
        }

        public void DownScore(int downScore)
        {
            score -= downScore;
        }
    }
}
