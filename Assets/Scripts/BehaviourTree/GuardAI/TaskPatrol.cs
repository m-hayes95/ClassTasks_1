using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviourTree;

public class TaskPatrol : Node 
{
    private const string WALKING = "Walking";
    private Transform _transform;
    private Transform[] _waypoints;
    private Animator _animator;

    private int _currentWaypointIndex = 0;

    private float _waitTime = 1f;
    private float _waitCounter = 0f;
    
    private bool _waiting = false;

    //[SerializeField] private float speed = 3f; 

    public TaskPatrol(Transform transform, Transform[] waypoints)
    {
        _transform = transform;
        _waypoints = waypoints;
    }

    //the evaluate method is called to evaluate the state of the task.
    public override NodeState Evaluate()
    {
        //if the character is waiting at a waypoint
        if(_waiting)
        {
            //check if the waiting time has passed
            _waitCounter += Time.deltaTime;
            if(_waitCounter >= _waitTime)
            {
                _waiting = false;
                _animator.SetBool(WALKING, true);
            }
        }
        else
        {
            //Get the current waypoint
            Transform wp = _waypoints[_currentWaypointIndex];
            //if the character has reached the waypoint
            if (Vector3.Distance(_transform.position, wp.position) < 0.01f)
            {
                _transform.position = wp.position;
                _waitCounter = 0f;
                _waiting = true;

                _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
                _animator.SetBool(WALKING, false);
            }
            else
            {
                _transform.position = Vector3.MoveTowards(_transform.position, wp.position, GuardBT.speed * Time.deltaTime);
                _transform.LookAt(wp.position);             
            }
        }

        state = NodeState.RUNNING;
        return state;
    } 

    
}
