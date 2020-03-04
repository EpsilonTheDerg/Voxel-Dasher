using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    // Alterable variable for field movement speed. Should slowly speed up over game time and affect obstacles by final build.
    // This line (public float speed = 25;) has been moved to MovementSpeedUp.cs
    public float speed;

    // Movement range
    public float rangeZ = 0;
    // Log the runway's initial position
    Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        // Save the initial position
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Pull from MovementSpeedUp.cs
        speed = MovementSpeedUp.gameSpeed;
        
        float movementZ = speed * Time.deltaTime;

        // New position
        float newZ = transform.position.z - movementZ;

        // Check to see if we've left the range limit
        if ( transform.position.z <= rangeZ )
        {
            transform.position = new Vector3(0, 0, 10);
        }
        // If still within range, move
        else
        {
            transform.position -= new Vector3(0, 0, movementZ);
        }
    }
}
