using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public bool moving;
    bool startPos;
    [SerializeField] Collider2D collisor;
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
                transform.position = new Vector3(17, transform.position.y);
                moving = false;
                startStartMoving(5);
                startPos = true;
            }
            if (startPos)
            {
                if (transform.position.x <= 2)
                {
                    moving = false;
                    startStartMoving(5);
                    transform.position = new Vector3(2, transform.position.y);
                    startPos = false;
                }
            }
            transform.position += new Vector3(-0.1f, 0, 0);
            collisor.enabled = true;
        } else
        {
            collisor.enabled = false;
        }
    }
    public void startStartMoving(float timer)
    {
        Invoke("startMoving", timer);
    }
    void startMoving()
    {
        moving = true;
    }
}
