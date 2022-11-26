using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class AI : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;
    [SerializeField]
    private int _currentPoint = 0;
    [SerializeField]
    public bool Reverse = false;
    [SerializeField]
    private NavMeshAgent _agent;

    [SerializeField]
    private States _currentState;
    private enum States
    {
        Walking,
        Attacking,
        Jumping,
    }
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        switch (_currentState)
        {
            case States.Walking:
                CalculateMovement();
                Debug.Log("Walking");
                break;
            case States.Attacking:
                Debug.Log("Attacking");
                break;
            case States.Jumping:
                Debug.Log("Jumping");
                break;
        }
    }

    void GetInput()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            _currentState = States.Jumping;
            _agent.isStopped = true;
        }
    }

    private void CalculateMovement()
    {
        if (_agent.remainingDistance < .2f)
        {
            _agent.destination = waypoints[_currentPoint].position;
            if (Reverse)
            {
                Reversal();
            }
            else
            {
                Forward();
            }
        }
    }

    void Forward()
    {
        _currentPoint += 1;
        if (_currentPoint >= waypoints.Length)
        {
            _currentPoint = waypoints.Length - 2;
            Reverse = true;
        }
    }
    private void Reversal()
    {
        _currentPoint -= 1;
        if (_currentPoint < 0)
        {
            _currentPoint = 1;
            Reverse = false;
        }
    }
}
