using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMalcolm : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 10.0f, x, y;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    { 
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Translate(0, 0, y * speed * Time.deltaTime);
    }

}
