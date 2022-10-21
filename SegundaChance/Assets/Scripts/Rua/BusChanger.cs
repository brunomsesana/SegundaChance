using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusChanger : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform movePoint;
    public bool touch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.endingsGot.Contains(2) && GameController.endingsGot.Contains(3) && GameController.endingsGot.Contains(4) && GameController.endingsGot.Contains(5))
        {
            if (GameController.endingsGot.Contains(1))
            {
                if (touch)
                {
                    if (transform.parent.GetComponent<Bus>().cutManager.cutscene == "bus1")
                    {
                        changeSceneTrabalho();
                    }
                }
            } else
            {
                if (transform.parent.GetComponent<Bus>().cutManager.cutscene == "")
                {
                    if (player.position.x == transform.position.x)
                    {
                        movePoint.position = new Vector3(movePoint.position.x, transform.position.y);
                    }
                    movePoint.position = new Vector3(transform.position.x, movePoint.position.y);
                    touch = false;
                }
            }
        } else
        {
            touch = false;
        }
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
                    if (GameController.endingsGot.Contains(2) && GameController.endingsGot.Contains(3) && GameController.endingsGot.Contains(4))
                    {
                        if (!GameController.endingsGot.Contains(5))
                        {
                            movePoint.position = new Vector2(movePoint.position.x, 2);
                            GetComponent<ScriptFalas>().StartCoroutine("Falar");
                            startMoving();
                        }
                        else
                        {
                            if (GameController.endingsGot.Contains(1))
                            {
                                collision.GetComponent<Player>().ControlOnOff(false);
                                player.gameObject.SetActive(false);
                                transform.parent.GetComponent<Bus>().enteredBus = true;
                                Invoke("startMoving", 0.8f);
                                Invoke("changeSceneTrabalho", 1.8f);
                            }
                        }
                    }
                    else
                    {
                        collision.GetComponent<Player>().ControlOnOff(false);
                        player.gameObject.SetActive(false);
                        transform.parent.GetComponent<Bus>().enteredBus = true;
                        Invoke("startMoving", 0.8f);
                        Invoke("changeSceneTrabalho", 1.8f);
                    }
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
