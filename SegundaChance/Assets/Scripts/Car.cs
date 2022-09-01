using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float modifier;
    float speed;
    Animator anim;
    public bool moving;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(10, 20);
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position = transform.position + new Vector3(1 * modifier  * speed * Time.deltaTime, 0);
            anim.SetBool("Andando", true);
        } else
        {
            anim.SetBool("Andando", false);
        }
        if (Mathf.Sign(transform.position.x) == 1)
        {
            if (transform.position.x >= 18)
            {
                transform.position = new Vector3(-18, transform.position.y);
                GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                speed = Random.Range(10, 20);
            }
        } else if (Mathf.Sign(transform.position.x) == -1)
        {
            if (transform.position.x <= -18)
            {
                transform.position = new Vector3(18, transform.position.y);
                GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                speed = Random.Range(10, 20);
            }
        }
    }
}
