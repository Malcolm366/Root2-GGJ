using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    GameObject cam;
    Slider volumeSlider;
    int volume;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        volumeSlider = GetComponent<Slider>();
        volume = PlayerPrefs.GetInt("Volume");
        volumeSlider.value = (float)(volume / 100.0f);
        
    }

    private void OnEnable()
    {
        volumeSlider = GetComponent<Slider>();
        volume = PlayerPrefs.GetInt("Volume");
        volumeSlider.value = (float)(volume / 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void OnSliderValueChanged()
    {
        volume = (int)(volumeSlider.value * 100.0f);
        cam.transform.GetComponent<AudioSource>().volume = volume;
        PlayerPrefs.SetInt("Volume", volume);

    }
}
