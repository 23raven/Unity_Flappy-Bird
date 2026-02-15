using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 3f;
    public float destroyX = -15f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // удаляем когда ушла за экран
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
