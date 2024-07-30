using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class End : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreText1;
    [SerializeField] Image[] stars;
    [SerializeField] Sprite on;
    [SerializeField] Sprite off;

    // Start is called before the first frame update
    void Start()
    {
        int lives = PlayerPrefs.GetInt("stars", 0);
        int score = PlayerPrefs.GetInt("score", 0);
        int time = PlayerPrefs.GetInt("time", 0);
        scoreText.text = "SCORE: " + score.ToString("D3") + "\nTIME: " + ((int)time).ToString("D3");
        scoreText1.text = lives > 0 ? "YOU WIN!" : "YOU LOSE";
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].sprite = i < lives ? on : off;
        }
        if(lives>0)
        {
            int current = PlayerPrefs.GetInt("current", 0);
            current++;
            PlayerPrefs.SetInt("current", current);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goBack()
    {
        SceneManager.LoadScene(2);
    }
}
