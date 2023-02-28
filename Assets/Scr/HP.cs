using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public int Health;
    public Text ZZ;
    
    public void Update()
    {
        ZZ.text = Health.ToString();
    }
}
