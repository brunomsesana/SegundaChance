using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DigitalRuby.SimpleLUT;

public class Bright : MonoBehaviour
{
    public GameObject MainCam;
    static float brightness = 0;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainCam.GetComponent<SimpleLUT>().Brightness = brightness;
    }
    public void BrightChanger(Slider slider)
    {
        brightness = slider.value / 100;
    }
}
