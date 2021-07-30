using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cubescript : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewaysForce = 100f; //sağ sol hızı

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0,  0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}


