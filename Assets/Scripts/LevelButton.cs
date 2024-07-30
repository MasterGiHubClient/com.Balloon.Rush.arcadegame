using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] int level;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Level " + (level + 1);
        int current = PlayerPrefs.GetInt("current", 0);
        Button button = GetComponent<Button>();
        button.interactable = level <= current;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(6);
    }
}
