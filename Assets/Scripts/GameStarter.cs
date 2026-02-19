using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GameObject startUI;
    public GameObject endGameUI;

    public static bool gameStarted = false;
    public static bool isGameOver = false;


    void Start()
    {
        gameStarted = false;
        isGameOver = false;

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
        endGameUI.SetActive(false);
        startUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
