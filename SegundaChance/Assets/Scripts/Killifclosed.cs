using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killifclosed : MonoBehaviour
{
    [SerializeField] GameObject moto;
    [SerializeField] TrafficLight l;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!l.closed)
            {
                moto.GetComponent<Rigidbody2D>().velocity = new Vector3(100, 0);
            }
        }
    }
}
