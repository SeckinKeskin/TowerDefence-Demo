using UnityEngine;

public interface IFactory
{
    public IProducible GetProduct();
    public void Generate(Vector2 position);
}
