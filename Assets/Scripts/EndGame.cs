using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;      // текущий счёт
    public TextMeshProUGUI finalScoreText; // финальный счёт
    public GameObject endGameMenu;

    void Start()
    {
        endGameMenu.SetActive(false);
    }

    void Update()
    {
        if (GameStarter.isGameOver)
        {
            ShowEndGame();
        }
    }

    void ShowEndGame()
    {
        // ⭐ копируем текст ДО скрытия
        finalScoreText.text = scoreText.text;

        scoreText.gameObject.SetActive(false);
        endGameMenu.SetActive(true);

        enabled = false;
    }
}
