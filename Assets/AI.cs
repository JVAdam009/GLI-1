using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;

    private int _currentPoint;

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
            _currentPoint = Random.Range(0, waypoints.Length);
        }

        _agent.destination = waypoints[_currentPoint].position;

    }
}
