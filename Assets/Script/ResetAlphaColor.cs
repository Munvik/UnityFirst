using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAlphaColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color newColor = new Vector4(255, 255, 255, 0);

        GetComponent<SpriteRenderer>().color = newColor;
    }

  
}
