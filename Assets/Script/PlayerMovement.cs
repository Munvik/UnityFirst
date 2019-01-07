
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int forwardSpeed = 1000;
    public int sidewaysForce = 300;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y <= -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
