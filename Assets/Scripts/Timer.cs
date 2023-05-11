using System;
using System.Collections;
using UnityEngine;

public class Timer
{
    public event Action TimerEnded;
    public event Action TimeChanged;
    private float _time = 0.0f;
    private float _target = 0.0f;
    private float _speed = 1.0f;
    private string _name = "Timer";
    public float time{ get => _time; }
    public float target { get => _target; }
    public float speed { get => _speed; }
    public string name { get => _name; set => _name = value; }

/// <summary>
/// When want to start the timer. First of all, timer should be set it.
/// </summary>
/// <param name="timeTarget">Destination point of time</param>
/// <param name="timeSpeed">Speed of time multiplier</param>
    public void SetTimer(float timeTarget, float timeSpeed = 1.0f)
    {
        _time = 0;
        _speed = speed;
        _target = timeTarget;
    }

    public IEnumerator StartTimer()
    {
        float timeLapse = 1.0f * _speed;
        _time = 0.0f;

        while(_time < _target)
        {
            yield return new WaitForSeconds(timeLapse);
            _time += timeLapse;
            
            TimeChangeHandler();
        }

        TimerEndHandler();
    }

    private void TimerEndHandler()
    {
        TimerEnded?.Invoke();
    }
    
    private void TimeChangeHandler()
    {
        TimeChanged?.Invoke();
    }
}