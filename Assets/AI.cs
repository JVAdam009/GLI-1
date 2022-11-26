using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField]
    private int _currentPoint = 0;
    [SerializeField]
    public bool Reverse = false;
    [SerializeField]
    private NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_agent.remainingDistance < .2f)
        {
            _agent.destination = waypoints[_currentPoint].position;
            if (Reverse)
            {
                _currentPoint -= 1;
                if (_currentPoint < 0)
                {
                    _currentPoint = 1;
                    Reverse = false;
                }
            }
            else
            {
                _currentPoint += 1;
                if (_currentPoint >= waypoints.Length)
                {
                    _currentPoint = waypoints.Length - 2;
                    Reverse = true;
                }
                
            }
        }


    }
}
