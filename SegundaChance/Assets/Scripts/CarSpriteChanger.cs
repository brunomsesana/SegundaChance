using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpriteChanger : MonoBehaviour
{
    [SerializeField] SpriteRenderer car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().sprite = car.sprite;
        GetComponent<SpriteRenderer>().color = car.color;
    }
}
