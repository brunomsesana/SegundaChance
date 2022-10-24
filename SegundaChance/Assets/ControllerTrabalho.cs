using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTrabalho : MonoBehaviour
{
    [SerializeField] DigitalRuby.SimpleLUT.SimpleLUT bri;
    private void Awake()
    {
        if (BusChanger.change)
        {
            bri.Brightness = -1f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BusChanger.change)
        {
            if (bri.Brightness < BusChanger.brightness)
            {
                bri.Brightness += 1.5f * Time.deltaTime;
            } else
            {
                BusChanger.change = false;
            }
        }
    }
}
