using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSize : MonoBehaviour
{
    public static int fontSize = 100;
    public int fontButton;
    Button btn;
    ColorBlock whitebtn;
    ColorBlock normalColors;

    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        normalColors = btn.colors;
        whitebtn = normalColors;
        whitebtn.normalColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (fontSize == fontButton)
        {
            btn.colors = whitebtn;
        } else
        {
            btn.colors = normalColors;
        }
    }

    public void ChangeFontSize()
    {
        fontSize = fontButton;
    }
}
