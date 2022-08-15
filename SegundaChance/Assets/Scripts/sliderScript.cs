using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.SimpleLUT;

public class sliderScript : MonoBehaviour
{
    Slider slider;
    public GameObject MainCam;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void VolumeChanger()
    {
        AudioListener.volume = slider.value / 100;
    }
}
