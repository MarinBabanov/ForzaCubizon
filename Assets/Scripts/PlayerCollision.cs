using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    //Collisions function
    //Declaring the object as an obstacle using a tag which will be checked upon collision with player
    void OnCollisionEnter (Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
