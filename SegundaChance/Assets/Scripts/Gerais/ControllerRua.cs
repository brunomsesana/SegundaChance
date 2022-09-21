using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRua : MonoBehaviour
{
    [SerializeField] Player p;
    // Start is called before the first frame update
    void Start()
    {
        p.anim.SetBool("Uniforme", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
