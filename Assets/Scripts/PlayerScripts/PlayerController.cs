using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    CharacterController controller;

    [SerializeField] public float WalkSpeed;
    [SerializeField] public float RunSpeed;
    [SerializeField] public float Gravity;
    [SerializeField] public float JumpHeight;

    Vector3 velocity;

    bool isGrounded;
    private float CurrentSpeed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        if (Input.GetKeyDown(KeyCode.P))
        {
            FindObjectOfType<MenuScripts>().TogglepauseMenu();
        } 
    }

    void move()
    {
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        CurrentSpeed = WalkSpeed;

        if (Input.GetButton("Sprint"))
        {
            CurrentSpeed = RunSpeed;
        }

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * CurrentSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        velocity.y += Gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
