using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] GameController cont;
    [SerializeField] GameObject playerMovePoint;
    [SerializeField] GameObject[] disObjs;
    [SerializeField] GameObject[] actObjs;
    Player p;
    Controls control;
    bool quest;
    bool waiting;
    private void Awake()
    {
        control = new Controls();
    }
    private void OnEnable()
    {
        control.Enable();
    }
    private void OnDisable()
    {
        control.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waiting)
        {
            if (playerMovePoint.transform.position == p.transform.position)
            {
                Time.timeScale = 0;
            }
            if (control.Timelines.Unpause.triggered)
            {
                p.cantMove = false;
                waiting = false;
                Time.timeScale = 1;
                foreach (GameObject gb in disObjs)
                {
                    gb.SetActive(true);
                }
                foreach (GameObject gb in actObjs)
                {
                    gb.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        quest = true;
        foreach (bool quest in cont.questsb)
        {
            if (!quest)
            {
                this.quest = false;
            }
        }
        if (collision.CompareTag("Player"))
        {
            if (quest)
            {
                GameController.SceneChange("Rua");
            } else
            {
                foreach (GameObject gb in disObjs)
                {
                    gb.SetActive(false);
                }
                foreach (GameObject gb in actObjs)
                {
                    gb.SetActive(true);
                }
                p = collision.GetComponent<Player>();
                playerMovePoint.transform.position = new Vector3(p.transform.position.x, p.transform.position.y + 2);
                p.cantMove = true;
                waiting = true;
            }
        }
    }
}
