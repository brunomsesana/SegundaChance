using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaMateo : MonoBehaviour
{
    [SerializeField] bool touching;
    Player p;
    bool started;
    [SerializeField] GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touching)
        {
            if (!panel.activeSelf)
            {
                p.eHelper.SetActive(true);
            } else
            {
                p.eHelper.SetActive(false);
            }
            if (p.control.Player.Interate.triggered && !started)
            {
                started = true;
                Time.timeScale = 0;
                panel.SetActive(true);
            }
        } else if (p)
        {
            p.eHelper.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touching = true;
            p = collision.GetComponent<Player>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touching = false;
        }
    }
}
