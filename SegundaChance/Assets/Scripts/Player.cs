using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rig;
    Controls control;
    public float speed;
    public Collider2D[] cols;
    public LayerMask colLayer;
    [SerializeField] GameObject pauseMenu;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        control = new Controls();
    }
    private void OnEnable()
    {
        control.Enable();
    }
    private void OnDisable()
    {
        control.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(control.Player.XAxis.ReadValue<float>() * speed, control.Player.YAxis.ReadValue<float>() * speed);
        if (control.Player.Pause.triggered)
        {
            if (Time.timeScale == 0)
            {
                GameController.Unpause();
                pauseMenu.SetActive(false);
            } else
            {
                GameController.Pause();
                pauseMenu.SetActive(true);
            }
        }
    }
}
