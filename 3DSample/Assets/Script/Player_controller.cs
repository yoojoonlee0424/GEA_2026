using UnityEngine;
using UnityEngine.InputSystem;

public class Player_controller : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float jumpPower = 5f;
    public float gravity = -20f;

    private float verticalVelocity;

    private Vector2 moveInput;
    private CharacterController characterController;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(characterController.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }


        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x,0, moveInput.y);
        move = move * moveSpeed;
        move.y = verticalVelocity;

        characterController.Move(move * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>(); 
    }

    public void OnJump(InputValue value)
    {
        if(value.isPressed && characterController.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }
}
