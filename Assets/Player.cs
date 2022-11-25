using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    private Ray _ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(_ray,out hit))
            {
                hit.transform.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(_ray);
    }
}
