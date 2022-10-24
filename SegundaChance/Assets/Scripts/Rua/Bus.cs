using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public bool moving;
    bool startPos;
    [SerializeField] Collider2D collisor;
    public CutsManager cutManager;
    public bool enteredBus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (cutManager.cutscene == "bus2")
        {
            if (transform.position.x >= 16)
            {
                moving = false;
            }
        }
        if (moving)
        {
            if (transform.position.x <= -18)
            {
                transform.position = new Vector3(17, transform.position.y);
                moving = false;
                startStartMoving(10);
                startPos = true;
            }
            if (startPos)
            {
                if (transform.position.x <= 2)
                {
                        moving = false;
                        startStartMoving(10);
                        transform.position = new Vector3(2, transform.position.y);
                        startPos = false;
                        if (cutManager.cutscene == "")
                        {
                            GetComponentInChildren<BusChanger>().touch = true;
                            cutManager.cutscene = "bus1";
                            cutManager.start = true;
                        } else if (cutManager.cutscene == "bus1")
                        {
                            GetComponentInChildren<BusChanger>().touch = true;
                            cutManager.cutscene = "bus2";
                            cutManager.start = true;
                        }
                }
            }
            transform.position += new Vector3(-18f * Time.deltaTime, 0, 0);
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
