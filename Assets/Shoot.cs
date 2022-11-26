using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullethole;

    [SerializeField] private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray camView = cam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
            RaycastHit _hit;
            if(Physics.Raycast(camView,out _hit))
            {
                Instantiate(_bullethole, _hit.point, Quaternion.LookRotation(_hit.normal));
            }
        }
    }
}
