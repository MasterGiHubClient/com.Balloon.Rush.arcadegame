using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{

    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundSlider;


    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("music", 1);
        soundSlider.value = PlayerPrefs.GetFloat("sounds", 1);
    }

    public void back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last", 2));
    }

    public void changeMusic()
    {
        PlayerPrefs.SetFloat("music", musicSlider.value);
        PlayerPrefs.Save();
        SoundManager.MusicVolume = musicSlider.value;
    }

    public void changeSounds()
    {
        PlayerPrefs.SetFloat("sounds", soundSlider.value);
        PlayerPrefs.Save();
        SoundManager.SoundVolume = soundSlider.value;
    }
}
