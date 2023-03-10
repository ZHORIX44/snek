using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CVET : MonoBehaviour
{
    Color lerpedColor = Color.white;
    float Health;

    void Update()
    {
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Health, 1));
    }
}

