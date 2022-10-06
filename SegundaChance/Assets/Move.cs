using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveIt(string xy)
    {
        transform.position = new Vector3(float.Parse(xy.Split('/')[0]), float.Parse(xy.Split('/')[1]));
    }
}
