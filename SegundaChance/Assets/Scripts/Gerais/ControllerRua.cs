using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRua : MonoBehaviour
{
    [SerializeField] Player p;
    [SerializeField] bool b;
    // Start is called before the first frame update
    void Start()
    {
        p.anim.SetBool("Uniforme", true);
        if (b)
        {
            p.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Pause()
    {
        Time.timeScale = 0;
    }
    public static void Unpause()
    {
        Time.timeScale = 1;
    }
}
