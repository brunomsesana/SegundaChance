using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
