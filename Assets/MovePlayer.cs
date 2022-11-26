using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePlayer : MonoBehaviour
{
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        Pointer.onClick += NewTartget;
    }

    // Update is called once per frame
    void Update()
    {  
            transform.position = Vector3.MoveTowards(transform.position,target,5 * Time.deltaTime);
    }

    void NewTartget(Vector3 tar)
    {
        target = tar; 
    }
}
