using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movementVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) 
        {
            movementVector = Vector3.forward;
        } else if (Input.GetKey(KeyCode.S))
        {
            movementVector = Vector3.back;
        } else if (Input.GetKey(KeyCode.A))
        {
            movementVector = Vector3.left;
        } else if (Input.GetKey(KeyCode.D))
        {
            movementVector = Vector3.right;
        }

        transform.Translate(movementVector * Time.deltaTime * speed);
    }
}
