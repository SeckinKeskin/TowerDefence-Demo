using System.Collections;
using UnityEngine;

public class CountDown
{
    private float _timer = 0.0f;

    public float timer{ get => _timer; }

    public CountDown(float timer)
    {
        _timer = timer;
    }

    public IEnumerator StartCountDown()
    {
        while(_timer > 0)
        {
            yield return new WaitForSeconds(1.0f);
            _timer -= 1.0f;
        }
    }
}