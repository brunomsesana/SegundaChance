using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColScript : MonoBehaviour
{
    [SerializeField] Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            col.enabled = true;
        }
    }
}