using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<Car>())
        {
            if (GetComponent<Car>().moving)
            {
                if (collision.gameObject.CompareTag("Player"))
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Rua");
                }
            }
        } else
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Rua");
            }
        }
    }
}