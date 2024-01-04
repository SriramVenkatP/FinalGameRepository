using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDeath : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position= new Vector3(0.2f,1.42f,-0.16f);
        }
    }
}
