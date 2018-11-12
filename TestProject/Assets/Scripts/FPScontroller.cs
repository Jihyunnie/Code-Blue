using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroller : MonoBehaviour
{
    public float speed = 2f;
    public float sensitivity = 2f;
    public GameObject eyes;
    CharacterController player;
    private float moveFB, moveLR, rotX, rotY, vertVelocity;
    private Vector3 Vector3;
    public float jumpForce = 4f;
    private bool hasJumped;
    // Use this for initialization
    void Start()
    {
        player = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetButtonDown("Jump"))
        {
            hasJumped = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            player.height = player.height / 3;
        }
        if(Input.GetButtonUp("Crouch"))
        {
            player.height = player.height * 3;
        }
        ApplyGravity();
    }
    void Movement()
    {
        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;
        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY -= Input.GetAxis("Mouse Y") * sensitivity;
        rotY = Mathf.Clamp(rotY, -60f, 60f);
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(rotY, 0, 0);
        eyes.transform.localRotation = Quaternion.Euler(rotY, 0, 0);
        Vector3 movement = new Vector3(moveLR, vertVelocity, moveFB);
        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);
        if (Input.GetButtonDown("Fire1"))
        {
            speed = speed * 4;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            speed = speed / 4;
        }
    }
    private void ApplyGravity()
    {
        if(player.isGrounded == true)
        {
            if(hasJumped == false)
            {
                vertVelocity = Physics.gravity.y;
            }
            else
            {
                vertVelocity = jumpForce;
            }
        }
        else
        {
            vertVelocity += Physics.gravity.y * Time.deltaTime;
            vertVelocity = Mathf.Clamp(vertVelocity, -50f, jumpForce);
            hasJumped = false;
        }
    }
}
