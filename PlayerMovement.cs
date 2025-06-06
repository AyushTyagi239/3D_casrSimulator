using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody RB;
    public float Forwardforce = 2f; // The forward force applied constantly
    public float MaxSpeed = 50f; // The maximum speed the car can move forward

    void Start()
    {
        Debug.Log("Game by Ayush Tyagi");
        // You can adjust the starting force, but usually, you'd want to apply it in FixedUpdate for consistent movement
        RB.AddForce(0, 2, 5); // Example of an initial force (but shouldn't be necessary in every start)
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Adding forward force continuously
        RB.AddForce(0, 0, Forwardforce); // Applies force in the forward direction

        // Clamp the forward speed to MaxSpeed (only on the Z axis)
        if (RB.velocity.z > MaxSpeed)
        {
            // Limit the Z (forward) velocity to MaxSpeed
            RB.velocity = new Vector3(RB.velocity.x, RB.velocity.y, MaxSpeed);
        }

        // Adding player controls for left/right and forward/backward movement
        if (Input.GetKey("d"))
        {
            RB.AddForce(50, 0, 0); // Applying force to move right
        }

        if (Input.GetKey("w"))
        {
            RB.AddForce(0, 0, 5 * Forwardforce); // Forward movement with more force when 'W' is pressed
        }

        if (Input.GetKey("a"))
        {
            RB.AddForce(-50, 0, 0); // Applying force to move left
        }

        if (Input.GetKey("s"))
        {
            RB.AddForce(0, 0, 0); // Applying downward force when 'S' is pressed (e.g., braking or going down)
        }
    }
}
