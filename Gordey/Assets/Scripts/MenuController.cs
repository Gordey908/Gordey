using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPanel, optionsPanel;
    private Text bestScoreText;
    [SerializeField]
    private Slider volumeSlider;
    public static int colorNum, bestScore;

    private enum Colors
    {
        WHITE = 1,
        YELLOW = 2,
        GREEN = 3
    }

    void Start()
    {
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        colorNum = PlayerPrefs.GetInt("ColorNum", 1);
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }

    void Update()
    {
        bestScoreText.text = "BestScore: " + bestScore.ToString();
        AudioListener.volume = volumeSlider.value;
    }

    public void SetColor(string colorSpriteName)
    {
        switch (colorSpriteName)
        {
            case "WHITE":
                colorNum = (int)Colors.WHITE;
                break;
            case "YELLOW":
                colorNum = (int)Colors.YELLOW;
                break;
            case "GREEN":
                colorNum = (int)Colors.GREEN;
                break;
        }
        PlayerPrefs.SetInt("ColorNum", colorNum);
    }

    public void OpenGameLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
