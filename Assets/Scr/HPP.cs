using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPP : MonoBehaviour
{
    public int Health;
    public Text ZZ;
    public void OnTriggerEnter(Collider other)
    {
        Health= 0;
        Object.Destroy(this.gameObject);
        Debug.Log("„B„p„ƒ„‘");
    }

    public void Update()
    {
        ZZ.text = Health.ToString();
    }
}
