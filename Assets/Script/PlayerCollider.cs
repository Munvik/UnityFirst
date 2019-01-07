using UnityEngine;


public class PlayerCollider : MonoBehaviour
{
   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
