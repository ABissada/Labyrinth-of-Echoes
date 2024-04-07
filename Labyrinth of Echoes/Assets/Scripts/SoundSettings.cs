using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void Start() {
        if (!PlayerPrefs.HasKey("masterVolume")) {
            PlayerPrefs.SetFloat("masterVolume", 1);
            load();
            
        }
        else {
            load();
        }
    }

    public void changeVolume() {
        AudioListener.volume = volumeSlider.value;
        save();
    }

    private void save() {
        PlayerPrefs.SetFloat("masterVolume", volumeSlider.value);
    }

    private void load() {
        volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }


}
