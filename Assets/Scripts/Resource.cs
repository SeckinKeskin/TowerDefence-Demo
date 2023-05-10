using System;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public event Action ResourceChanged;
    public int minResource => _minResource;
    public int maxResource => _maxResource;
    public int currentResource
    {
        get => _currentResource;
        set => _currentResource = value;
    }

    private const int _minResource = 0;
    private const int _maxResource = 100;
    private int _currentResource;

    public void Increment(int amount)
    {
        _currentResource += amount;
        _currentResource = Mathf.Clamp(_currentResource, _minResource, _maxResource);

        UpdateResource();
    }

    public void Decrement(int amount)
    {
        _currentResource -= amount;
        _currentResource = Mathf.Clamp(_currentResource, _minResource, _maxResource);

        UpdateResource();
    }

    public void Reset()
    {
        _currentResource = _minResource;

        UpdateResource();
    }

    public void UpdateResource()
    {
        ResourceChanged?.Invoke();
    }
}
