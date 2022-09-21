using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public bool closed;
    [SerializeField] List<Car> cars;
    [SerializeField] float timerRes;
    [SerializeField] Sprite[] sprs;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerRes;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        } else
        {
            if (closed)
            {
                closed = false;
            } else
            {
                closed = true;
            }
            timer = timerRes;
        }
        if (closed)
        {
            GetComponent<SpriteRenderer>().sprite = sprs[1];
            //col.SetActive(false);
        } else
        {
            //col.SetActive(true);
            GetComponent<SpriteRenderer>().sprite = sprs[0];
            foreach (Car c in cars)
            {
                c.moving = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            if (closed)
            {
                collision.GetComponent<Car>().moving = false;
                if (!cars.Contains(collision.GetComponent<Car>()))
                {
                    cars.Add(collision.GetComponent<Car>());
                }
            }
        }
    }
}
