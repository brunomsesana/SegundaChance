using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingText : MonoBehaviour
{
    [SerializeField] int ending;
    [SerializeField] string text;
    // Start is called before the first frame update
    void Start()
    {
        if (GameController.endingsGot.Contains(ending))
        {
            GetComponent<TMPro.TMP_Text>().text = text;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
