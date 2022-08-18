using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rig;
    Controls control;
    [SerializeField] float speed;
    public Transform movePoint;
    [SerializeField] Collider2D[] cols;
    [SerializeField] LayerMask colLayer;
    [SerializeField] GameObject pauseMenu;
    Animator anim;
    SpriteRenderer spr;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        control = new Controls();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
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
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);
        //rig.velocity = new Vector2(control.Player.XAxis.ReadValue<float>() * speed, control.Player.YAxis.ReadValue<float>() * speed);
        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            if (control.Player.YAxis.ReadValue<float>() != 0)
            {
                if (!cols[0].IsTouchingLayers(colLayer))
                {
                    if (control.Player.YAxis.ReadValue<float>() > 0)
                    {
                        movePoint.position += new Vector3(0f, 1f, 0f);
                    }
                }
                if (!cols[1].IsTouchingLayers(colLayer))
                {
                    if (control.Player.YAxis.ReadValue<float>() < 0)
                    {
                        movePoint.position += new Vector3(0f, -1f, 0f);
                    }
                }
            }
            else
            {
                if (!cols[2].IsTouchingLayers(colLayer))
                {
                    if (control.Player.XAxis.ReadValue<float>() > 0)
                    {
                        movePoint.position += new Vector3(1f, 0f, 0f);
                    }
                }
                if (!cols[3].IsTouchingLayers(colLayer))
                {
                    if (control.Player.XAxis.ReadValue<float>() < 0)
                    {
                        movePoint.position += new Vector3(-1f, 0f, 0f);
                    }
                }
            }
            if (control.Player.XAxis.ReadValue<float>() == 0 && control.Player.YAxis.ReadValue<float>() == 0)
            {
                anim.SetBool("Andando", false);
            }
        } else
        {
            anim.SetBool("Andando", true);
        }
        if (transform.position.x > movePoint.position.x)
        {
            anim.SetInteger("Lado", 2);
            spr.flipX = true;
        } else if (transform.position.x < movePoint.position.x)
        {
            anim.SetInteger("Lado", 2);
            spr.flipX = false;
        } else if (transform.position.y > movePoint.position.y)
        {
            anim.SetInteger("Lado", 1);
        } else if (transform.position.y < movePoint.position.y)
        {
            anim.SetInteger("Lado", 3);
        }
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
