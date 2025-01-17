using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;


    private void onEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();

        }
        playerControls.Enable();

    }

    private void onDisable()
    {
        playerControls.Disable();
    }
    public void HandleAllInputs()
    {
         HandleMovementInput();
        //HandleJumpingInput
        //HandleActionInput
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;    
    } 
}
