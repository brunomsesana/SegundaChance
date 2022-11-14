using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    bool fading;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fading){
            GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, (0.4f * Time.deltaTime));
        }
        if (GetComponent<SpriteRenderer>().color.a >= 1){
            fading = false;
        }
    }

    public void Fade(){
        fading = true;
    }
}
