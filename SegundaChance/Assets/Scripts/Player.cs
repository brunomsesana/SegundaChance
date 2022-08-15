using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rig;
    Controls control;
    public float speed;
    float timer = 70f;
    string showTime;
    public TMPro.TMP_Text text;
    //float walkTime = 0.15f;
    public Collider2D[] cols;
    public LayerMask colLayer;

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
        //walkTime -= Time.deltaTime;
        rig.velocity = new Vector2(control.Player.XAxis.ReadValue<float>() * speed, control.Player.YAxis.ReadValue<float>() * speed);
        /*if (walkTime <= 0)
        {
            //Vector3 vec = Vector3.MoveTowards(transform.position, transform.position + new Vector3(Arre(control.Player.XAxis.ReadValue<float>()), Arre(control.Player.YAxis.ReadValue<float>()), 0), 2);
            if (control.Player.YAxis.ReadValue<float>() > 0.4f)
            {
                if (!cols[0].IsTouchingLayers(colLayer))
                {
                    transform.position += new Vector3(0, 1, 0);
                    walkTime = 0.2f;
                }
            }
            if (control.Player.YAxis.ReadValue<float>() < -0.4f)
            {
                if (!cols[1].IsTouchingLayers(colLayer))
                {
                    transform.position += new Vector3(0, -1, 0);
                    walkTime = 0.2f;
                }
            }
            if (control.Player.XAxis.ReadValue<float>() > 0.4f)
            {
                if (!cols[2].IsTouchingLayers(colLayer))
                {
                    transform.position += new Vector3(1, 0, 0);
                    walkTime = 0.2f;
                }
            }
            if (control.Player.XAxis.ReadValue<float>() < -0.4f)
            {
                if (!cols[3].IsTouchingLayers(colLayer))
                {
                    transform.position += new Vector3(-1, 0, 0);
                    walkTime = 0.2f;
                }
            }
        }*/
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 31)
        {
            text.color = Color.red;
        }
        if (timer <= 60)
        {
            text.text = string.Format("{0:00}:{1:00}", (int)(timer % 60), (int)(timer * 100 % 100));
        } else
        {
            text.text = string.Format("{0:00}:{1:00}", (int)(timer / 60), (int)(timer % 60));
        }
            
    }

    int Arre(float f)
    {
        if (f < 0)
        {
            return -1;
        } else if (f > 0){
            return 1;
        } else
        {
            return 0;
        }
    }
}
