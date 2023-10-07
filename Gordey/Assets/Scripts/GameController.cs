using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel, gamePanel;
    public Text startText;
    [SerializeField] private Text scoreText, bestScoreText;
    public int score;

    void Start()
    {
        score = 0;
        pausePanel.SetActive(false);
        gamePanel.SetActive(false);
        scoreText.text = "Score: " + score.ToString();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void SwitchPause()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
        gamePanel.SetActive(!gamePanel.activeSelf);
        switch (Time.timeScale) // Fixed "Time.timescale" to "Time.timeScale"
        {
            case 1:
                Time.timeScale = 0;
                break;
            case 0:
                Time.timeScale = 1;
                break;
            default:
                break;
        }
    }
}
