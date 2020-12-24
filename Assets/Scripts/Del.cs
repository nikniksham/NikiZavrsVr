using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y <= -30) { Destroy(gameObject); }
    }
}
