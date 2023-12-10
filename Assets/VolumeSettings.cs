using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;



public class VolumeSettings : MonoBehaviour
{

    [SerializeField] private AudioMixer theMixer;
    [SerializeField] private Slider     musicSlider;
    [SerializeField] private Slider     sfxSlider;


    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
                LoadVolume();
        }
        else
        {
                SetMusicVolume();
                SetSFXVolume();
        }

    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        theMixer.SetFloat("musicExposed", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSFXVolume()
    {
        float volume = sfxSlider.value;
        theMixer.SetFloat("sfxExposed", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");

        SetMusicVolume();
        SetSFXVolume();
    }








}
