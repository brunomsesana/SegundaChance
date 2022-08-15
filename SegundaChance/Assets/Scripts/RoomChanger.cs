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
        Vector3 pos = new Vector3(rC.transform.position.x + posMod, rC.transform.position.y + 0.2f, rC.transform.position.z);
        collision.transform.parent.position = pos;
        thisVCam.enabled = false;
        nextVCam.enabled = true;
    }
}
