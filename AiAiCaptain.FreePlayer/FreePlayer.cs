using AiAiCaptain.FreePlayer.Interfaces;
using System;

namespace AiAiCaptain.FreePlayer
{
    public class FreePlayer : IFreePlayer
    {
        public void OnGameStart(ISubmarine submarine)
        {
           
            submarine.MoveLeft();
            submarine.MoveLeft();
            submarine.MoveLeft();
        }
    }
}
