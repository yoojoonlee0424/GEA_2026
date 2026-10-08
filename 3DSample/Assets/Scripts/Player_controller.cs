using UnityEngine;
using UnityEngine.InputSystem;

public class Player_controller : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float jumpPower = 5f;
    public float gravity = -20f;

    public float mouseSensitivity = 0.2f;
    private Vector2 lookInput;

    private float verticalVelocity;

    private Vector2 moveInput;
    private CharacterController characterController;

    public Transform cameraPivot;
    public Transform cameraTransform;

    private float pitch = 20f;

    private bool isRunning;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, lookInput.x * mouseSensitivity, 0f);

        pitch = pitch - lookInput.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -50f, 60f);
        cameraPivot.localEulerAngles = new Vector3(pitch, 0f, 0f);

        if(characterController.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }


        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * moveInput.y + transform.right * moveInput.x;
        float speed = moveSpeed;
        float targetZ = -6f;
        if (isRunning)
        {
            speed = moveSpeed * 3f;
            targetZ = -8f;
        }
        move = move * speed;
        move.y = verticalVelocity;

        Vector3 camPos = cameraTransform.localPosition;
        camPos.z = Mathf.Lerp(camPos.z, targetZ, 5f * Time.deltaTime);
        cameraTransform.localPosition = camPos;

        characterController.Move(move * Time.deltaTime);
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>(); 
    }

    public void OnSprint(InputValue value)
    {
        isRunning = value.isPressed;
    }

    public void OnJump(InputValue value)
    {
        if(value.isPressed && characterController.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }
}
