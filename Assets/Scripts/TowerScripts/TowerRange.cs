using System;
using UnityEngine;

public class TowerRange
{
    public event Action RangeChanged;

    private const float _minRange = 0.1f;
    private const float _maxRange = 5.0f;
    private const float _value = 0.5f;
    private float _amount;
    private float _range;

    public float range => _range;
    public float maxRange => _maxRange;
    public float minRange => _minRange;

/// <summary>
/// Agility * Intelligence = Range Amount
/// Range = Range Amount * const Value;
/// </summary>
/// <param name="amount">Size multiplier</param>
    public TowerRange(float amount)
    {
        _amount = amount;

        RangeHandler();
    }

    public void RangeHandler()
    {
        _range = _value * _amount;
        _range = Mathf.Clamp(_range, _minRange, _maxRange);
    }

    public void RangeUp(float amount)
    {
        _amount = amount;

        RangeHandler();
        UpdateRange();
    }
    
    //Use for Range in UI.
    public void UpdateRange()
    {
        RangeChanged?.Invoke();
    }
}
