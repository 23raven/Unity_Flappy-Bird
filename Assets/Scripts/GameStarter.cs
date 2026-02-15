using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GameObject startUI;

    public static bool gameStarted = false;
    public static bool isGameOver = false;


    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        // если игра уже началась »Ћ» произошЄл GameOver Ч игнорируем ввод
        if (gameStarted || isGameOver) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameStarted = true;
        startUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
