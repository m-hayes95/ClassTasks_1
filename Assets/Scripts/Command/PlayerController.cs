using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MoveCommand _moveCommand;

    public void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody == null)
        {
            gameObject.AddComponent<Rigidbody>();
        }

        Vector3 movement = new Vector3(1f, 0f, 0f);

        _moveCommand = new MoveCommand(rigidbody, movement);
    }

    public void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Add Foce");
            _moveCommand.Execute();
        }
    }
}
