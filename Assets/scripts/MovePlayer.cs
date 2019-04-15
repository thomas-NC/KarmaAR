using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 7f;
    public float rotateSpeed = 50f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(0, 0, moveVertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);

        //Rotation
        transform.Rotate(0, moveHorizontal * 2, 0);

    }
}
