using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] bool endings;
    [SerializeField] bool createEndings;
    // Start is called before the first frame update
    void Start()
    {
        if (endings)
        {
            Time.timeScale = 1;
        }
        if (createEndings)
        {
            GameController.endingsGot = new List<int>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void SceneDelay(string cena){
        StartCoroutine(ChangeSceneDelay(cena));
    }
    IEnumerator ChangeSceneDelay(string cena){
        yield return new WaitForSeconds(3);
        ChangeScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void InsertEnding(int end)
    {
        GameController.endingsGot.Add(end);
    }

    public void EndGame()
    {
        GameController.endingsGot = new List<int>();
        for (var i = 1; i < 6; i++)
        {
            InsertEnding(i);
        }
    }
}
