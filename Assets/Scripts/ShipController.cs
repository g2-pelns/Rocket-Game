﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public float thrust;
    public Rigidbody2D rb;
    public float midPoint;
    public Transform upDir;
    void Start ()
    {
        midPoint = Screen.width / 2;
        rb = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Fire1") > 0f)
        {
            if (Input.mousePosition.x < midPoint)
            {
                rb.transform.eulerAngles -= Vector3.forward * 2;
            }
            else if (Input.mousePosition.x >= midPoint)
            {
                rb.transform.eulerAngles += Vector3.forward * 2;
            }

            rb.AddForce((upDir.position - transform.position).normalized * thrust);
        }
	}
}
