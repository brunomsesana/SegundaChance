using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bug : MonoBehaviour
{
    [SerializeField] GameObject contBtn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteObj", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DeleteObj()
    {
        contBtn.SetActive(true);
        Destroy(gameObject);
    }
}
