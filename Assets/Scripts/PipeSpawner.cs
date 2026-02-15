using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnRate = 2f;
    public float spawnX = 10f;

    public float gap = 4f;
    public float heightRange = 3f;

    float pipeHalfHeight;

    void Start()
    {
        // автоматически получаем высоту префаба
        SpriteRenderer sr = pipePrefab.GetComponent<SpriteRenderer>();
        pipeHalfHeight = sr.bounds.size.y / 2f;

        InvokeRepeating(nameof(SpawnPipes), 1f, spawnRate);
    }

    void SpawnPipes()
    {
        float centerY = Random.Range(-heightRange, heightRange);

        // нижн€€ труба Ч еЄ верх должен быть у gap
        float bottomY = centerY - gap / 2f - pipeHalfHeight;

        // верхн€€ труба Ч еЄ низ должен быть у gap
        float topY = centerY + gap / 2f + pipeHalfHeight;

        Instantiate(pipePrefab,
            new Vector3(spawnX, bottomY, 0),
            Quaternion.identity);

        Instantiate(pipePrefab,
            new Vector3(spawnX, topY, 0),
            Quaternion.Euler(0, 0, 180));
    }
}
