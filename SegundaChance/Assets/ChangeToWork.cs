using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("Uniforme", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
