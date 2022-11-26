using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
public class Pointer : MonoBehaviour
{
    public static Action<Vector3> onClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit hit;
            Ray _ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(_ray, out hit))
            {
                Debug.Log(hit.point);
                onClick?.Invoke(hit.point);
            }
        }
    }
    
    
}
