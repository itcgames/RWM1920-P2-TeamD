using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public GameObject slider;

    public void OnSliderValueChanged(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
