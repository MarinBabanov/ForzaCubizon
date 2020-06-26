using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Sample values stored in varaibles to be adjusted later in the inspector
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Forward constant force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Sideway movement using arrow keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}