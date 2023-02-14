using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private Rigidbody _rigidbody;
    private Vector3 _movement;

    public MoveCommand(Rigidbody rigidbody, Vector3 movement)
    {
        _rigidbody = rigidbody;
        _movement = movement;
    }
    public void Execute()
    {
        _rigidbody.AddForce(_movement, ForceMode.Impulse);
    }

    /*private void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Execute();
        }
    }*/
}
