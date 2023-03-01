using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;

    // Reference to player controller input script.
    [SerializeField] private GameInput gameInput;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions(); // Define new player inputs.
        playerInputActions.Enable(); // Enable the new player inputs.
    }

    private void Update()
    {
        // Set the Vector2 as the GetMovementVector method.
        Vector2 inputVector = gameInput.GetMovementVector();



    }

    public Vector2 GetMovementVector()
    {
        // Define new vector for movement input.
        // Reads value from the new controller > Player > Move as a vector 2.
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        //Return the inputVector value.
        return inputVector;
    }
}
