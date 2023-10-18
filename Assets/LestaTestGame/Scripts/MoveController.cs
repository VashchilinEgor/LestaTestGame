using UnityEngine;

public sealed class MoveController : MonoBehaviour,
        IStartGameListener,
        IFinishGameListener
{
    [SerializeField]
    private KeyboardInput input;

    [SerializeField]
    private Player player;

    void IStartGameListener.OnStartGame()
    {
        this.input.OnMove += this.OnMove;
    }

    void IFinishGameListener.OnFinishGame()
    {
        this.input.OnMove -= this.OnMove;
    }

    private void OnMove(Vector3 direction)
    {
        this.player.Move(direction);
    }
}

public interface IStartGameListener
{
    void OnStartGame();
}

public interface IPauseGameListener
{
    void OnPauseGame();
}

public interface IResumeGameListener
{
    void OnResumeGame();
}

public interface IFinishGameListener
{
    void OnFinishGame();
}