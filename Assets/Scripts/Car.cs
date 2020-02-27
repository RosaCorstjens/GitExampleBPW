using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,Random.Range(0,360),0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right*speed*Time.deltaTime);
    }
}
