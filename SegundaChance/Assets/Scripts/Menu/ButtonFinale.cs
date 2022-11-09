using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Cinemachine;

public class ButtonFinale : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] int ending;
    [SerializeField] int ending2;
    [SerializeField] Button otherBtn;
    [SerializeField] int otherEnding;
    [SerializeField] int otherEnding2;
    [SerializeField] Button endingRight;

    [SerializeField] Move movepoint;
    [SerializeField] GameObject panel;
    [SerializeField] CinemachineVirtualCamera salaChefe;
    [SerializeField] CinemachineVirtualCamera salaMateo;
    [SerializeField] Move player;
    [SerializeField] GameObject roomChanger;
    [SerializeField] GameObject starter;
    [SerializeField] GameObject starter2;
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
                    if (ending == 2){
                        GetComponent<Button>().onClick.AddListener(fim346);
                    } else {
                        GetComponent<Button>().onClick.AddListener(fim2);
                    }
                }
                else
                {
                    if (GameController.endingsGot.Contains(otherEnding2))
                    {
                        starter = starter2;
                        GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                        //Tentar trocar isso aqui para um botão com o final verdadeiro e ver se funciona
                        GetComponent<Button>().onClick.AddListener(fim346);
                    } else
                    {
                        GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                        GetComponent<Button>().onClick.AddListener(fim346);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fim2(){
        Finais.ChangeEnding(2);
        SceneManager.LoadScene("Finais");
    }
    public void fim346(){
        movepoint.MoveIt("100,5/26");
        panel.SetActive(false);
        salaChefe.enabled = true;
        salaMateo.enabled = false;
        player.MoveIt("100,5/22");
        typeof(GameController).GetMethod("Unpause").Invoke(null, null);
        roomChanger.SetActive(false);
        starter.SetActive(true);
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
