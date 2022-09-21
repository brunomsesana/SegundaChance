using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finais : MonoBehaviour
{
    [SerializeField] bool controller;
    public static int ending;
    [SerializeField] GameObject ending1;
    [SerializeField] GameObject ending2;
    [SerializeField] GameObject ending3;
    [SerializeField] GameObject ending6;
    // Start is called before the first frame update
    void Start()
    {
        if (controller)
        {
            if (ending == 1)
            {
                ending1.SetActive(true);
            } else if (ending == 2)
            {
                ending2.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeEnding(int end)
    {
        ending = end;
    }
}
