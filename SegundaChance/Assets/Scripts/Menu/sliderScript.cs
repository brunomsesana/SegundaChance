using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.SimpleLUT;
using UnityEngine.EventSystems;

public class sliderScript : MonoBehaviour, IDeselectHandler, ISelectHandler
{
    Slider slider;
    [SerializeField] bool brightness;
    [SerializeField] bool volume;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (brightness)
        {
            slider.value = Bright.brightness * 100f;
        }
        if (volume)
        {
            slider.value = AudioListener.volume * 100;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void VolumeChanger()
    {
        AudioListener.volume = slider.value / 100;
    }
    
    public void OnDeselect(BaseEventData data)
    {
        if (GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
    public void OnSelect(BaseEventData data){
        if (!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
