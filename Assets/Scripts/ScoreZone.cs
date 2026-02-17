using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    bool counted = false;
    PipeSpawner spawner;

    void Start()
    {
        spawner = FindObjectOfType<PipeSpawner>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (counted) return;
        if (!GameStarter.gameStarted || GameStarter.isGameOver) return;

        if (other.CompareTag("Player"))
        {
            counted = true;
            spawner.AddScore();
        }
    }
}
