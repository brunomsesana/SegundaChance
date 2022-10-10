using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] float timer = 90f;
    [SerializeField] TMPro.TMP_Text text;
    [SerializeField] bool useTimer;
    [SerializeField] string[] quests;
    public List<bool> questsb;
    [SerializeField] bool useQuests;
    [SerializeField] TMPro.TMP_Text showQuests;
    [SerializeField] RuntimeAnimatorController animCont;
    float timerp = 0.5f;
    float timerf = 2f;
    bool started;
    bool questsfinished = true;
    public static bool timerFinished;
    [SerializeField] Collider2D cama;
    [SerializeField] UnityEngine.Playables.PlayableDirector cutStart;
    [SerializeField] Player p;
    [SerializeField] bool notFirstTime;
    [SerializeField] TMPro.TMP_Text startLine;

    private void Awake()
    {
        p = GameObject.Find("Player").GetComponent<Player>();
        if (p.Casa)
        {
            switch (Player.lastEnding)
            {
                case 0:
                    if (Player.restarts == 0)
                    {
                        startLine.text = "Nossa, estou muito atrasado, tenho que correr!!";
                    } else
                    {
                        startLine.text = "Que sonho esquisito, achei que tinha morrido! Foi tão... realista.";
                    }
                    break;
                case 1:
                    startLine.text = "É... Um novo dia, não posso perder mais um dia de trabalho.";
                    break;
                case 2:
                    startLine.text = "Droga, não acredito que fui demitido ontem, vou ter que ir até lá e ver se consigo meu emprego de volta";
                    break;
                case 3:
                    startLine.text = "Não acredito que me atrasei tanto assim, espero que não me demitam hoje.";
                    break;
                case 4:
                    startLine.text = "Que? como vim parar aqui? Achei que eu estivesse preso... Espero que o chefe esteja bem, não sei o que deu em mim.";
                    break;
            }
            p.transform.position = new Vector3(-8, 2);
            p.movePoint.position = new Vector3(-8, 2);
            cama.enabled = false;
            cutStart.Play();
            Player.lastEnding = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Rua")
        {
            if (!timerFinished)
            {
                //Debug.Log("Conseguiu");
            } else
            {
                //Debug.Log("Não conseguiu");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (useTimer)
        {
            if ((int)timer > 0)
            {
                timer -= Time.deltaTime;
                timerFinished = false;
            } else
            {
                timer = 0;
                timerFinished = true;
            }
            if ((int)timer <= 10 && (int)timer > 0)
            {
                text.GetComponent<Fonts>().enabled = false;
                text.fontSize += 0.02f * Time.deltaTime * 1000;
            }
            if (timer <= 31 && (int)timer > 0)
            {
                text.color = Color.red;
            }
            text.text = string.Format("{0:00}:{1:00}", (int)(timer / 60), (int)(timer % 60));
            if ((int)timer <= 0)
            {
                timerp -= Time.deltaTime;
                timerf -= Time.deltaTime;
                if (timerp <= 0 && text.color == new Color(1, 0, 0, 1))
                {
                    text.color = new Color(0, 0, 0, 0);
                    timerp = 0.5f;
                }
                if (timerp <= 0 && text.color == new Color(0, 0, 0, 0))
                {
                    text.color = new Color(1, 0, 0, 1);
                    timerp = 0.5f;
                }
                if (timerf <= 0 && !started)
                {
                    GameObject.Find("Player").transform.position = new Vector2(19, -11);
                    GameObject.Find("PlayerMovePoint").transform.position = new Vector2(19, -11);
                    GameObject.Find("Player").GetComponent<Animator>().runtimeAnimatorController = animCont;
                    GetComponent<CutsceneController>().Play();
                    started = true;
                }
            }
        }
        if (useQuests)
        {
            showQuests.text = "";
            questsfinished = true;
            for (int i = 0; i < quests.Length; i++)
            {
                if (i < questsb.Count)
                {
                    if (!questsb[i])
                    {
                        showQuests.text += "\n" + quests[i];
                    }
                } else
                {
                    questsb.Add(false);
                }
            }
            foreach (bool q in questsb)
            {
                if (!q)
                {
                    questsfinished = false;
                }
            }
            if (questsfinished)
            {
                showQuests.text = "\n- Sair";
            }
        }
    }
    public static void SceneChange(string cena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
    }
    public static void Pause()
    {
        Time.timeScale = 0;
    }
    public static void Unpause()
    {
        Time.timeScale = 1;
    }
    public void finishQuests()
    {
        for (int i = 0; i < questsb.Count; i++)
        {
            questsb[i] = true;
        }
    }
}
