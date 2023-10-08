using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawned : MonoBehaviour
{
    public float threshold;


    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(0f, 1.39f, 0f);
        }
    }
}

        