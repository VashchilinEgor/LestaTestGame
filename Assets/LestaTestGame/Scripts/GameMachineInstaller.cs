using UnityEngine;

public sealed class GameMachineInstaller : MonoBehaviour
{
    [SerializeField]
    private GameMachine gameMachine;

    [SerializeField]
    private MonoBehaviour[] gameListeners;

    private void Awake()
    {
        foreach (var listener in this.gameListeners)
        {
            this.gameMachine.AddListener(listener);
        }
    }
}