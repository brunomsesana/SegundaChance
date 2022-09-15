using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusChanger : MonoBehaviour
{
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
            if (!transform.parent.GetComponent<Bus>().moving)
            {
                if (transform.parent.GetComponent<Bus>().cutManager.cutscene == "")
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene("Finais");
                } else if (transform.parent.GetComponent<Bus>().cutManager.cutscene == "bus1")
                {
                    collision.GetComponent<Player>().ControlOnOff(false);
                    Invoke("changeScene", 2);
                }
                else
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
                }
            }
        }
    }
    void changeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Trabalho");
    }
}
