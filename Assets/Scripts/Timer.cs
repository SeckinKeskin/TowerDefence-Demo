using System;
using System.Collections;
using UnityEngine;

public class Timer
{
    public event Action TimerEnded;
    public event Action TimeChanged;
    public float time{ get; private set; }
    public float target { get; private set; }
    public float speed { get; private set; }
    public string name { get; private set; }

    public void SetTimer(float timeTarget, float timeSpeed = 1.0f)
    {
        time = 0;
        speed = timeSpeed;
        target = timeTarget;
    }

    public IEnumerator StartTimer()
    {
        float timeLapse = 1.0f * speed;
        time = 0.0f;

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