using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;

    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
	public float rotateSpeed = 2.0f; 
	private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Move(x, z);
		Jump();
		AnimationsControl(x, z);
	}

	private void Move(float x, float z)
	{
		
		Vector3 move = transform.forward * z + transform.right * x;
		Debug.Log(move * Time.deltaTime * playerSpeed);
		controller.Move(move * Time.deltaTime * playerSpeed);
	}

	private void AnimationsControl(float hAxis, float vAxis)
	{
		// Contorl the animation parts
		if (hAxis == 0)
		{
			animator.SetBool("walkLeft", false);
			animator.SetBool("walkRight", false);
		}
		else if (hAxis < 0)
		{
			animator.SetBool("walkLeft", true);
			animator.SetBool("walkRight", false);
		}
		else if (hAxis > 0)
		{
			animator.SetBool("walkLeft", false);
			animator.SetBool("walkRight", true);
		}

		if (vAxis == 0)
		{
			animator.SetBool("walkForward", false);
			animator.SetBool("walkBackward", false);
		}
		else if (vAxis < 0)
		{
			animator.SetBool("walkBackward", true);
			animator.SetBool("walkForward", false);
		}
		else if (vAxis > 0)
		{
			animator.SetBool("walkBackward", false);
			animator.SetBool("walkForward", true);
		}
	}

	private void Jump()
	{
		groundedPlayer = controller.isGrounded;
		if (groundedPlayer && playerVelocity.y < 0)
		{
			playerVelocity.y = 0f;
		}

		// Changes the height position of the player..
		if (Input.GetButtonDown("Jump") && groundedPlayer)
		{
			playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
		}

		playerVelocity.y += gravityValue * Time.deltaTime;
		controller.Move(playerVelocity * Time.deltaTime);
	}
}