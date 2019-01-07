
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameManagerScript gameManager;
    


    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
