using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    //private variables
    private Resolution[] rsl;
    private List<string> resolutions;
    private bool isFullScreen = false;
    //public variables
    public AudioMixer am;
    public Slider sl;
    public Dropdown dropdown;
    public Toggle toggle;
    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }
    public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }
    //Fullscreen off/on
    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    //Setting audio volume for audioMixer
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sl.value);
    }
    //Quality setting
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
