using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] float timer = 90f;
    [SerializeField] TMPro.TMP_Text text;
    [SerializeField] bool useTimer;
    [SerializeField] string[] quests;
    [SerializeField] bool useQuests;
    [SerializeField] TMPro.TMP_Text showQuests;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useTimer)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 31)
            {
                text.color = Color.red;
            }
            if (timer <= 60)
            {
                text.text = string.Format("{0:00}:{1:00}", (int)(timer % 60), (int)(timer * 100 % 100));
            }
            else
            {
                text.text = string.Format("{0:00}:{1:00}", (int)(timer / 60), (int)(timer % 60));
            }
        }
        if (useQuests)
        {
            foreach (string quest in quests)
            {
                showQuests.text += "\n" + quest;
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
