using UnityEngine;

public class GameState : State
{
    private GameManager gameManager;

    public override void Initialize()
    {
        gameManager = GameManager.Instance;

        Debug.Log("Turn Begin!");
    }

    public override void Active()
    {
        Debug.Log("Enemy Spawn & Tower Attacks!");
    }

    public override void Close()
    {
        Debug.Log("Turn End!");
    }
}