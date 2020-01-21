using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public Slider slider;

	public AudioSource volumeModifier;

    public string paramaterName;

    private void Awake()
    {
		volumeModifier.volume = PlayerPrefs.GetFloat("volume");
		float savedVol = PlayerPrefs.GetFloat("volume");
        SetLevel(savedVol);
        slider.value = savedVol;
        slider.onValueChanged.AddListener((float _) => SetLevel(_));
    }

    public void SetLevel(float value)
    {
        mixer.SetFloat(paramaterName, ConvertToDecibel(value/slider.maxValue));
        PlayerPrefs.SetFloat(paramaterName, value);
		volumeModifier.volume = PlayerPrefs.GetFloat("volume");
	
	}

    public float ConvertToDecibel(float value)
    {
        return Mathf.Log10(Mathf.Max(value, 0.0001f)) * 20f;
    }
}
