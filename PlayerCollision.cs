using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // A reference to our PlayerMovement script
    

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            // Ensure that the movement reference is not null.
            if (movement != null)
            {
                movement.enabled = false; // Disable the player's movement
                FindObjectOfType<GameManager>().EndGame();

            }
            else
            {
                Debug.LogError("PlayerMovement reference is missing!");
            }
        }
    }
}
