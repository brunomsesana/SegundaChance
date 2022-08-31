using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorbike : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 18)
        {
            transform.position = new Vector3(-18, transform.position.y);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0);
        }
    }
}
