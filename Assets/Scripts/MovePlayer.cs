using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Movement (Strafing, really) speed
    public float moveSpeed = 8;

    // Define RigidBody
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get X input
        float hAxis = Input.GetAxis("Horizontal");

        // Keep for debug purposes
        // print(hAxis);

        // Prepare movement
        Vector3 movementX = new Vector3(hAxis * moveSpeed * Time.deltaTime, 0, 0);
        Vector3 newPosX = transform.position + movementX;
        rb.MovePosition(newPosX);
    }
}
