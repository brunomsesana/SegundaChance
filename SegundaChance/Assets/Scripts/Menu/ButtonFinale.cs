using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonFinale : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] int ending;
    [SerializeField] int ending2;
    [SerializeField] Button otherBtn;
    [SerializeField] int otherEnding;
    [SerializeField] int otherEnding2;
    [SerializeField] Button endingRight;
    // Start is called before the first frame update
    void Start()
    {
        if (GameController.endingsGot.Contains(ending))
        {
            if (GameController.endingsGot.Contains(ending2))
            {
                if (!GameController.endingsGot.Contains(otherEnding))
                {
                    GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                    GetComponent<Button>().onClick.AddListener(Clicar);
                }
                else
                {
                    if (GameController.endingsGot.Contains(otherEnding2))
                    {
                        GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                        //Tentar trocar isso aqui para um botão com o final verdadeiro e ver se funciona
                        GetComponent<Button>().onClick.AddListener(ClicarCerto);
                    } else
                    {
                        GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                        GetComponent<Button>().onClick.AddListener(Clicar);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Clicar()
    {
        otherBtn.onClick.Invoke();
    }
    void ClicarCerto()
    {
        endingRight.onClick.Invoke();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (GameController.endingsGot.Contains(ending))
        {
            if (GameController.endingsGot.Contains(ending2))
            {
                if (!GameController.endingsGot.Contains(otherEnding))
                {
                    GetComponentInChildren<TMPro.TMP_Text>().text = otherBtn.GetComponentInChildren<TMPro.TMP_Text>().text;
                } else
                {
                    GetComponentInChildren<TMPro.TMP_Text>().text = endingRight.GetComponentInChildren<TMPro.TMP_Text>().text;
                }
            }
        }
    }
}
