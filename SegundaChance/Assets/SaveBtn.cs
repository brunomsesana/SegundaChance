using UnityEngine;
using UnityEngine.UI;

public class SaveBtn : MonoBehaviour
{
    [SerializeField] int saveNum;
    // Start is called before the first frame update
    void Start()
    {
        SetRestarts();
        SetColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteSave()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/save" + saveNum + ".exa")){
            SaveSystem.DeletePlayer(saveNum);
            SetColor();
            SetRestarts();
        }
    }
    void SetColor()
    {
        ColorBlock col = new ColorBlock();
        col.highlightedColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        col.pressedColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        col.selectedColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        col.fadeDuration = 0.1f;
        col.colorMultiplier = 1;
        if (!System.IO.File.Exists(Application.persistentDataPath + "/save" + saveNum + ".exa"))
        {
            col.normalColor = Color.gray;
        }
        else
        {
            col.normalColor = Color.white;
        }
        GetComponent<Button>().colors = col;
    }
    void SetRestarts()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/save" + saveNum + ".exa")){
            PlayerData data = SaveSystem.LoadPlayer(saveNum);
            GetComponentInChildren<TMPro.TMP_Text>().text = "Reinícios: " + data.restarts;
        } else
        {
            GetComponentInChildren<TMPro.TMP_Text>().text = "New Game";
        }
    }
}
