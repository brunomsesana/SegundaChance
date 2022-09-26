using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFalas : MonoBehaviour
{
    [SerializeField] string[] falas;
    [SerializeField] bool[] falasBool;
    [SerializeField] bool touching;
    Player p;
    Controls control;
    [SerializeField] TMPro.TMP_Text textoFala;
    [SerializeField] UnityEngine.UI.Image imgCabeca;
    [SerializeField] Sprite cabecaOutro;
    [SerializeField] Sprite cabecaPlayer;
    int fala = 0;
    bool started;
    [SerializeField] bool startAuto;
    [SerializeField] bool salaReuniao;
    [SerializeField] GameObject pMovePoint;
    [SerializeField] bool moreThanOnce;

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
        if (touching)
        {
            if (!started)
            {
                if (control.Player.Interate.triggered)
                {
                    StartCoroutine(Falar());
                } else if (startAuto)
                {
                    StartCoroutine(Falar());
                }
            } else
            {
                if (control.Timelines.Unpause.triggered)
                {
                    StartCoroutine(Falar());
                }
            }
        }
    }
    private IEnumerator Falar()
    {
        started = true;
        if (fala < falas.Length)
        {
            textoFala.text = falas[fala];
            if (!falasBool[fala])
            {
                imgCabeca.sprite = cabecaOutro;
            } else
            {
                imgCabeca.sprite = cabecaPlayer;
            }
            textoFala.transform.parent.gameObject.SetActive(true);
            fala += 1;
            p.ControlOnOff(false);
        } else
        {
            p.ControlOnOff(true);
            textoFala.transform.parent.gameObject.SetActive(false);
            if (salaReuniao)
            {
                pMovePoint.transform.position = new Vector3(60, 24);
                fala = 0;
                started = false;
                touching = false;
            }
            if (moreThanOnce)
            {
                fala = 0;
                started = false;
            }
            yield return null;
        }
        // just a simple time delay as an example
        yield return new WaitForSeconds(2.5f);

        // wait for player to press space
        yield return waitForKeyPress(control.Timelines.Unpause.triggered); // wait for this function to return
    }

    private IEnumerator waitForKeyPress(bool k)
    {
        bool done = false;
        while (!done)
        {
            if (k)
            {
                done = true;
            }
            yield return null;
        }

        // now this function returns
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
