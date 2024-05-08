using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDRaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool didHit = Physics2D.Raycast(transform.position, Vector2.down);
        Debug.Log(didHit);
    }
}
