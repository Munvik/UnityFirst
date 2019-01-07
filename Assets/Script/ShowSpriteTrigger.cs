using UnityEngine;
using System.Collections;

public class ShowSpriteTrigger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        StartCoroutine(FindObjectOfType<GameManagerScript>().ShowEndSprite());
    }
}
