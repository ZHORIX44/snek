using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont : MonoBehaviour
{
    public Transform Head;
    public float S;
    public float V;
    public Rigidbody R;
    public int VPERED;

    private void Start()
    {
        R = GetComponent<Rigidbody>();
        
    }
    private void FixedUpdate()
    {
        Time.fixedDeltaTime= 0.01f;
        R.velocity = new Vector3(-8, 0, 0);
        //R.AddForce(-VPERED, 0, 0,ForceMode.Impulse);        
        //Vector3 CurrentVelocity= R.velocity;
        //CurrentVelocity.x =Mathf.Clamp(CurrentVelocity.x, 0, 20);
        //CurrentVelocity.y = Mathf.Clamp(CurrentVelocity.y, 0, 20);
        //CurrentVelocity.z = Mathf.Clamp(CurrentVelocity.z, 0, 20);
        //R.velocity = CurrentVelocity;
    }
    void Update()
    {
        //R.velocity = new Vector3(-4,0,0);

        if (Input.GetKey(KeyCode.D))
        {
            Head.transform.position += Head.transform.forward * S;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Head.transform.position -= Head.transform.forward * S;
        }
        Head.transform.position = new Vector3(
            Head.transform.position.x,
            Head.transform.position.y,
            Mathf.Clamp(Head.transform.position.z, 1, 19)
        );
    }
    
}

