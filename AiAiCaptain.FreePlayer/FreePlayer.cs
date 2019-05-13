using AiAiCaptain.FreePlayer.Interfaces;
using System;

namespace AiAiCaptain.FreePlayer
{
    public class FreePlayer : IFreePlayer
    {
        public void OnGameStart(ISubmarine submarine)
        {
            for (int i = 0; i < 10; i++) {
                submarine.MoveRight();
            }
        }

        public void OnGameStart(ISubmarineWithContext submarine)
        {
            for (int i = 0; i < 2; i++)
            {
                if (submarine.CanMoveForward())
                {
                    submarine.MoveForward();
                }
            }
        }
    }
}
