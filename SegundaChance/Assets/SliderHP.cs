using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderHP : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TMP_Text>().text = slider.value + "/10";
    }
}
