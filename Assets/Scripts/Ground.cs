using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 0.1f;
    private void Update()
    {
        gameObject.transform.Translate(0, 0, -1 * speed); 
    }
}
