using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // True if player win otherwise false
        public bool Play()
        {
            // Run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                foreach (Tower tower in Towers)
                {
                    // Each tower has opportunity to fire on invaders
                    tower.FireOnInvaders(_invaders);
                }

                // Count and move the invader that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActivate)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}
