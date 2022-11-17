using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    bool fading;
    [SerializeField] Sprite mao;
    [SerializeField] bool noFade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!noFade)
        {
            if (fading){
                GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, (0.4f * Time.deltaTime));
            }
            if (GetComponent<SpriteRenderer>().color.a >= 1){
                fading = false;
                Invoke("ActiveHand", 0.3f);
            }
        } else
        {
            Invoke("ActiveHand", 2.8f);
            Invoke("Change", 3f);
        }
    }

    void ActiveHand()
    {
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = mao;
    }
    void Change()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Casa");
    }

    public void Fade(){
        fading = true;
    }
}
