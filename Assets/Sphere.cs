using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    [SerializeField] private float distance = 1f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RaycastHit _hit;
        if (Physics.Raycast(transform.position,Vector3.down, out _hit, distance))
        {
            if (_hit.collider.name.Equals("Floor"))
            {
                rb.useGravity = false;
                rb.isKinematic = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        var position = transform.position;
        Gizmos.DrawLine(position,position + Vector3.down * distance);
    }
}
