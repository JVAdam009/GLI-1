using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiObjectClick : MonoBehaviour
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
                if (hit.transform.gameObject != null)
                {
                    if (hit.transform.tag.Equals("Cube"))
                    {
                        hit.transform.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
                    }
                    else if (hit.transform.tag.Equals("Capsule"))
                    {
                        hit.transform.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                }
            }
        }
    }
}
