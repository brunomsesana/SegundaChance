using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    bool moving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            if (transform.position.x <= -18)
            {
                transform.position = new Vector3(17, 0, 0);
                moving = false;
            }
            transform.position += new Vector3(-0.1f, 0, 0);
        }
    }
    public void startStartMoving()
    {
        Invoke("startMoving", 5);
    }
    void startMoving()
    {
        moving = true;
    }
}
