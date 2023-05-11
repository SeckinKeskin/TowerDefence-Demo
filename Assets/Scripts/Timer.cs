using System;
using System.Collections;
using UnityEngine;

public class Timer
{
    public event Action TimerEnded;
    private float _time = 0.0f;
    private float _target = 0.0f;
    private float _rate = 1.0f;
    private string _name = "Timer";
    public float time{ get => _time; }
    public float target { get => _target; }
    public float rate { get => _rate; }
    public string name { get => _name; set => _name = value; }

/// <summary>
/// When want to start the timer. First of all, timer should be set it.
/// </summary>
/// <param name="timeTarget">Destination point of time</param>
/// <param name="timeRate">Speed of time multiplier</param>
    public void SetTimer(float timeTarget, float timeRate = 1.0f)
    {
        _time = 0;
        _rate = rate;
        _target = timeTarget;
    }

    public IEnumerator StartTimer()
    {
        float timeLapse = 1.0f * _rate;
        _time = 0.0f;

        while(_time < _target)
        {
            yield return new WaitForSeconds(timeLapse);
            _time += timeLapse;
        }

        TimerEndHandler();
    }

    public void TimerEndHandler()
    {
        TimerEnded?.Invoke();
    }
}