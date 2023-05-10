using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] public TowerTypePresenter towerTypePresenter;
    [SerializeField] private IProducible product;
    private StateMachine stateMachine = new StateMachine();

    void Start()
    {
        SetTowerType();

        stateMachine.Initialize(new GameState());
    }

    public void Generator(IFactory factory, Vector2 generatePosition)
    {
        product = factory.GetProduct();
        product.Initialize();
        
        factory.Generate(generatePosition);
    }

    public void SetTowerType()
    {
        towerTypePresenter.SetTypes();
    }
}