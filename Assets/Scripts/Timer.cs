using System;
using System.Collections;
using UnityEngine;

public class Timer
{
    public event Action TimerEnded;
    public event Action TimeChanged;
    public float time { get; private set; } = 0.0f;
    public float target { get; private set; } = 5.0f;
    public float speed { get; private set; } = 1.0f;
    public string name { get; private set; } = "Timer";

    public Timer(float timeTarget, float timeSpeed = 1.0f)
    {
        time = 0;
        speed = timeSpeed;
        target = timeTarget;
    }

    public IEnumerator StartTimer()
    {
        time = 0.0f;
        float timeLapse = 1.0f * speed;

        while(time < target)
        {
            yield return new WaitForSeconds(timeLapse);
            time += timeLapse;
            
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