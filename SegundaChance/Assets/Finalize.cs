using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finalize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetAllFinal()
    {
        GameController.endingsGot = new List<int>();
        GameController.endingsGot.Add(2);
        GameController.endingsGot.Add(3);
        GameController.endingsGot.Add(4);
        GameController.endingsGot.Add(5);
    }
}
