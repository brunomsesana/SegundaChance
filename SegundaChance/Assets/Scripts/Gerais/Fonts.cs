using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fonts : MonoBehaviour
{
    string whatis;
    TMP_Text text;
    GameObject gmo;
    public float divisor = 1;

    private void Awake()
    {
        if (GetComponent<TMP_Text>())
        {
            text = GetComponent<TMP_Text>();
            whatis = "text";
        } else if (GetComponent<Button>() || GetComponent<Image>() || GetComponent<RawImage>())
        {
            gmo = gameObject;
            whatis = "image";
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (whatis == "text")
        {
            text.fontSize = FontSize.fontSize / divisor;
        } else if (whatis == "image")
        {
            gmo.transform.localScale = new Vector2(FontSize.fontSize / 100f , FontSize.fontSize / 100f);
        }
    }
}
