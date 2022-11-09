using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrigaController : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text text;
    [SerializeField] TMPro.TMP_Text chefeText;
    [SerializeField] UnityEngine.UI.Slider HPChefe;
    [SerializeField] UnityEngine.UI.Slider HPMateo;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HPChefe.value <= 0)
        {
            GetComponent<SceneChanger>().ChangeScene("Finais");
            Finais.ChangeEnding(3);
        }
        if (HPMateo.value <= 0)
        {
            GetComponent<SceneChanger>().ChangeScene("Finais");
            Finais.ChangeEnding(4);
        }
    }
    public void Attack(GameObject texto)
    {
        text.text = "Mateo usa '" + texto.GetComponent<TMPro.TMP_Text>().text + "'";
        texto.transform.parent.parent.gameObject.SetActive(false);
        text.transform.parent.gameObject.SetActive(true);
    }
    public void Change(GameObject next)
    {
        this.next = next;
    }
    public void Continue()
    {
        next.SetActive(true);
        text.transform.parent.gameObject.SetActive(false);
    }
    public void Chefe(string texto)
    {
        chefeText.text = "Chefe usa '" + texto + "'";
    }
    public void ContinueChefe(GameObject t)
    {
        next.SetActive(true);
        t.SetActive(false);
    }
    public void DamageChefe(int dano)
    {
        if (!GameController.endingsGot.Contains(4))
        {
            HPChefe.value -= dano;
        } else
        {
            HPChefe.value -= dano + 2;
        }
    }

    public void DamageMateo(int dano)
    {
        if (GameController.endingsGot.Contains(3))
        {
            HPMateo.value -= 4;
        }
        else if (GameController.endingsGot.Contains(4))
        {
            HPMateo.value -= 1;
        }
        else
        {
            HPMateo.value -= dano;
        }
    }
}
