using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewaysForce = 5f; //sağ sol hızı

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * sidewaysForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * sidewaysForce * Time.deltaTime);
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}


