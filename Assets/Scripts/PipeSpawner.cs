using UnityEngine;
using TMPro;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject scoreZonePrefab;

    public float spawnRate = 2f;
    public float spawnX = 10f;

    public float gap = 4f;
    public float heightRange = 3f;

    public TextMeshProUGUI scoreText;
    int score = 0;

    float pipeHalfHeight;

    void Start()
    {
        score = 0;
        UpdateScoreUI();

        SpriteRenderer sr = pipePrefab.GetComponent<SpriteRenderer>();
        pipeHalfHeight = sr.bounds.size.y / 2f;

        InvokeRepeating(nameof(SpawnPipes), 1f, spawnRate);
    }

    void SpawnPipes()
    {
        float centerY = Random.Range(-heightRange, heightRange);

        float bottomY = centerY - gap / 2f - pipeHalfHeight;
        float topY = centerY + gap / 2f + pipeHalfHeight;

        Instantiate(pipePrefab,
            new Vector3(spawnX, bottomY, 0),
            Quaternion.identity);

        Instantiate(pipePrefab,
            new Vector3(spawnX, topY, 0),
            Quaternion.Euler(0, 0, 180));

        // ⭐ создаём ScoreZone внутри gap
        Instantiate(scoreZonePrefab,
            new Vector3(spawnX, centerY, 0),
            Quaternion.identity);
        
    }

    public void AddScore()
    {
        if (GameStarter.isGameOver) return;

        score++;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }
}
