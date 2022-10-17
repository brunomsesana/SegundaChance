using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNext : MonoBehaviour
{
    [SerializeField] BrigaController cont;
    [SerializeField] ChangeNext m;
    public GameObject next;
    [SerializeField] bool escolha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Changer()
    {
        Invoke("ChangeNextA", 0.2f);
    }

    void ChangeNextA()
    {
        if (escolha)
        {
            m.next = next;
        } else
        {
            cont.next = next;
        }
    }
}
