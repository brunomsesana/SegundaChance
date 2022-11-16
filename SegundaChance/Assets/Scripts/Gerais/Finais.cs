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
    [SerializeField] GameObject ending4;
    [SerializeField] GameObject ending5;
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
            } else if (ending == 3)
            {
                ending3.SetActive(true);
            } else if (ending == 4)
            {
                ending4.SetActive(true);
            } else if (ending == 5)
            {
                ending5.SetActive(true);
            } else if (ending == 6)
            {
                ending6.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void ChangeEnding(int end)
    {
        ending = end;
    }
}
