using System;
using UnityEngine;

public class Experience : MonoBehaviour
{
    public event Action experienceChanged;

    private const int _minExperience = 0;
    private const int _maxExperience = 100;

    private int _currentExperience;

    public int currentExperience
    {
        get => _currentExperience;
    }
}