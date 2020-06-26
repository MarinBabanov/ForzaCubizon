using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    // Fixing camera to follow player
    void Update()
    {
        transform.position = player.position + offset;
        
    }
}
