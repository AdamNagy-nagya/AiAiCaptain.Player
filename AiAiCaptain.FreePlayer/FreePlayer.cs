using AiAiCaptain.FreePlayer.Interfaces;
using AiAiCaptain.FreePlayer.Submarines;
using System;

namespace AiAiCaptain.FreePlayer
{
    public class FreePlayer : IFreePlayer
    {
        public void OnGameStart(ISubmarine submarine)
        {
            for (int i = 0; i < 10; i++) {
                submarine.MoveLeft();
            }
        }
    }
}
