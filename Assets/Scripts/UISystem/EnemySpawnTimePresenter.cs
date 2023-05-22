using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnTimePresenter : MonoBehaviour
{
    [SerializeField] private EnemyFactory enemyFactory;
    [SerializeField] private Transform enemySpawnPoint;
    [SerializeField] private Text countDownText;
    [SerializeField] private float spawnTime = 5.0f;
    private Timer timer;

    public void ResetTimer()
    {
        SetTimer();
        StartTimer();
    }

    private void SetTimer()
    {
        timer = new Timer();
        timer.SetTimer(spawnTime);

        timer.TimerEnded += OnCountDownEnded;
        timer.TimeChanged += OnTimeChanged;

        countDownText.text = timer.target.ToString();
    }

    private void StartTimer()
    {
        StartCoroutine(timer?.StartTimer());
    }

    private void SpawnHandler()
    {
        timer.TimerEnded -= OnCountDownEnded;
        timer.TimeChanged -= OnTimeChanged;

        GameManager.Instance.Generator(enemyFactory);
        ResetTimer();
    }

    private void OnCountDownEnded()
    {
        SpawnHandler();
    }
    
    private void OnTimeChanged()
    {
        countDownText.text = (timer.target - timer.time).ToString();
    }
}