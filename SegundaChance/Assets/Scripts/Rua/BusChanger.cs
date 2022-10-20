using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusChanger : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform movePoint;
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
                    if (!GameController.endingsGot.Contains(1))
                    {
                        collision.GetComponent<Player>().ControlOnOff(false);
                        player.gameObject.SetActive(false);
                        transform.parent.GetComponent<Bus>().enteredBus = true;
                        Invoke("startMoving", 0.8f);
                        Invoke("changeSceneFinais", 1.8f);
                    } else
                    {
                        movePoint.position = new Vector2(movePoint.position.x, 2);
                        GetComponent<ScriptFalas>().StartCoroutine("Falar");
                        startMoving();
                    }
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
                    collision.GetComponent<Player>().ControlOnOff(false);
                    player.gameObject.SetActive(false);
                    transform.parent.GetComponent<Bus>().enteredBus = true;
                    Invoke("startMoving", 0.8f);
                    Invoke("changeSceneFinais2", 1.8f);
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
    void changeSceneFinais2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Finais");
        Finais.ending = 5;
    }
    void startMoving()
    {
        transform.parent.GetComponent<Bus>().moving = true;
    }
}
