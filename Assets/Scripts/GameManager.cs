using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] public TowerTypePresenter towerTypePresenter;
    [SerializeField] private EnemySpawnTimePresenter enemySpawnTimePresenter;
    private IProducible product;
    private StateMachine stateMachine = new StateMachine();
    
    void Start()
    {
        SetTowerType();

        enemySpawnTimePresenter.ResetTimer();

        stateMachine.Initialize(new GameState());
    }

    public void Generator(IFactory factory)
    {
        product = factory.GetProduct();

        product.Initialize();
        product.SetPosition();

        factory.Generate();
    }

    public void SetTowerType()
    {
        towerTypePresenter.SetTypes();
    }
}