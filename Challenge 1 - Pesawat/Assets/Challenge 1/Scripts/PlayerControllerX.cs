﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    Rigidbody Rb;
    public float speed = 20.0f;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
    }

    private void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "Obstacle")
        {
            //Destroy(gameObject); // hilang
            speed *= -1; // memantul
        }
    }

}
