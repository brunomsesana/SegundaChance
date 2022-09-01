using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    public bool closed;
    [SerializeField] GameObject col;
    [SerializeField] List<Car> cars;
    [SerializeField] float timerRes;
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
            GetComponent<SpriteRenderer>().color = Color.green;
            //col.SetActive(false);
        } else
        {
            //col.SetActive(true);
            GetComponent<SpriteRenderer>().color = Color.red;
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
