using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody R;
    public int NAZAD;
    private void Start()
    {
        R = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.name == "Kvadrat")
        {
            R.AddForce(NAZAD,0,0);
            collision.gameObject.GetComponent<HP>().Health--;
            
            if (collision.gameObject.GetComponent<HP>().Health == 0)
            {
                Destroy(collision.gameObject);
                Debug.Log(collision.gameObject);
            }
        }
        
    }

}
