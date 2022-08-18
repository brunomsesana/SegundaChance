using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] float timer = 90f;
    [SerializeField] TMPro.TMP_Text text;
    [SerializeField] bool useTimer;
    [SerializeField] string[] quests;
    [SerializeField] List<bool> questsb;
    [SerializeField] bool useQuests;
    [SerializeField] TMPro.TMP_Text showQuests;
    [SerializeField] float timerp = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useTimer)
        {
            if ((int)timer > 0)
            {
                timer -= Time.deltaTime;
            } else
            {
                timer = 0;
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
            }
        }
        if (useQuests)
        {
            showQuests.text = "";
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
}
