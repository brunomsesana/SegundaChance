using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusChanger : MonoBehaviour
{
    [SerializeField] Transform player;
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
                    collision.GetComponent<Player>().ControlOnOff(false);
                    player.gameObject.SetActive(false);
                    transform.parent.GetComponent<Bus>().enteredBus = true;
                    Invoke("startMoving", 0.8f);
                    Invoke("changeSceneFinais", 1.8f);
                } else if (transform.parent.GetComponent<Bus>().cutManager.cutscene == "bus1")
                {
                    collision.GetComponent<Player>().ControlOnOff(false);
                    player.gameObject.SetActive(false);
                    transform.parent.GetComponent<Bus>().enteredBus = true;
                    Invoke("startMoving", 0.8f);
                    Invoke("changeSceneTrabalho", 1.8f);
                }
                else
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
                }
            }
        }
    }
    void changeSceneTrabalho()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Trabalho");
    }
    void changeSceneFinais()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Finais");
        Finais.ending = 1;
    }
    void startMoving()
    {
        transform.parent.GetComponent<Bus>().moving = true;
    }
}