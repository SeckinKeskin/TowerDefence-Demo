using System.Collections;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float timer = 0.0f;

    private void Start()
    {

    }

    private void Update()
    {
        if(timer  > 0)
        {
            timer -= Time.deltaTime;

            Debug.Log(Mathf.Floor(timer));
        }
    }

    public IEnumerator StartCountDown()
    {
        while(timer > 0)
        {
            Debug.Log("CD: " + timer.ToString());
            yield return new WaitForSeconds(1.0f);
            timer -= 1.0f;
        }
    }
}