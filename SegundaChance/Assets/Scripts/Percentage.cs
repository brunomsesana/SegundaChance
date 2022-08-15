using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percentage : MonoBehaviour
{
    TMPro.TMP_Text text;
    public Slider slider;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float range = slider.maxValue - slider.minValue;
        float value = Mathf.Abs((slider.value - slider.minValue) / range * 100f);
        text.text = (int)value + "%";
    }
}
