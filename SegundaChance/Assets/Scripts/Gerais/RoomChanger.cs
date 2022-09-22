using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RoomChanger : MonoBehaviour
{
    public GameObject rC;
    public float posMod;
    public CinemachineVirtualCamera thisVCam;
    public CinemachineVirtualCamera nextVCam;
    public bool x = true;
    public bool sideChange;
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
            if (x)
            {
                Vector3 pos = new Vector3(rC.transform.position.x + posMod, rC.transform.position.y, rC.transform.position.z);
                collision.transform.position = pos;
                if (!sideChange)
                {
                    collision.transform.GetComponent<Player>().movePoint.position = pos;
                } else
                {
                    collision.transform.GetComponent<Player>().movePoint.position = pos + new Vector3(Mathf.Sign(posMod) * 1, 0, 0);
                }
            }
            else
            {
                Vector3 pos = new Vector3(rC.transform.position.x, rC.transform.position.y + posMod, rC.transform.position.z);
                collision.transform.position = pos;
                if (!sideChange)
                {
                    collision.transform.GetComponent<Player>().movePoint.position = pos;
                } else
                {
                    collision.transform.GetComponent<Player>().movePoint.position = pos + new Vector3(0, Mathf.Sign(posMod) * 1, 0);
                }
            }
            thisVCam.enabled = false;
            nextVCam.enabled = true;
        }
    }
}
