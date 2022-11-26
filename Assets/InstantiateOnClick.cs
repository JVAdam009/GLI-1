using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
public class InstantiateOnClick : MonoBehaviour
{
    private Ray _ray;
    [SerializeField] private GameObject _gameObject;
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
            _ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());


            if (Physics.Raycast(_ray, out hit))
            {
                if (hit.transform.gameObject != null)
                {
                    Instantiate(_gameObject, hit.point, quaternion.identity);
                }
            }
        }
    }
}
