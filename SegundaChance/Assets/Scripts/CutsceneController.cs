using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneController : MonoBehaviour
{
    PlayableDirector timel;
    bool paused;
    Controls control;
    public GameObject[] falas;
    public GameObject player;
    public GameObject playerMovePoint;
    public Vector3 playerPos;
    public Vector3 finalPos;
    [SerializeField] bool cutStart;
    private void OnEnable()
    {
        control.Enable();
    }
    private void OnDisable()
    {
        control.Disable();
    }
    private void Awake()
    {
        control = new Controls();
        timel = GetComponent<PlayableDirector>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            if (cutStart)
            {
                player.GetComponent<Player>().anim.SetInteger("Lado", 1);
            }
            player.transform.position = playerPos;
            playerMovePoint.transform.position = player.transform.position;
            if (control.Timelines.Unpause.triggered)
            {
                timel.Resume();
                playerMovePoint.transform.position = finalPos;
                paused = false;
                foreach (GameObject fala in falas)
                {
                    fala.SetActive(false);
                }
                Time.timeScale = 1;
            }
        }
    }
    public void Pause()
    {
        paused = true;
        timel.Pause();
    }
    public void Play()
    {
        paused = false;
        timel.Play();
    }
    public void StopTime()
    {
        Time.timeScale = 0;
    }
}
