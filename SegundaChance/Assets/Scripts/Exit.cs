using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] GameController cont;
    bool quest;
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
        quest = true;
        foreach (bool quest in cont.questsb)
        {
            if (!quest)
            {
                this.quest = false;
            }
        }
        if (quest)
        {
            if (collision.CompareTag("Player"))
            {
                GameController.SceneChange("Rua");
            }
        }
    }
}
