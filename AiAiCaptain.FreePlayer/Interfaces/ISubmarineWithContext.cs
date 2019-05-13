namespace AiAiCaptain.FreePlayer.Interfaces
{
    public interface ISubmarineWithContext
    {
        void MoveForward();
        void MoveLeft();
        void MoveRight();
        bool CanMoveForward();
        bool CanMoveLeft();
        bool CanMoveRight();
    }
}
