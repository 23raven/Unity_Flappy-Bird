using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public int clickForce = 8;   // сила прыжка вверх
    public int gravity = 20;     // сила падени€ вниз

    float velocityY = 0f;
    bool isDead = false;

    void Update()
    {
        if (!GameStarter.gameStarted) return;
        // ввод Ч Space или Ћ ћ
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            velocityY = clickForce;
        }

        // гравитаци€
        velocityY -= gravity * Time.deltaTime;

        // движение
        transform.position += new Vector3(0, velocityY * Time.deltaTime, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("Pipe"))
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;

        Debug.Log("Game Over");

        GameStarter.isGameOver = true;

        Time.timeScale = 0f;
    }
}
