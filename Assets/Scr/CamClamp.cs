using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamClamp : MonoBehaviour
{
    public GameObject CAM;
    void Start()
    {

        
    }
    private void FixedUpdate()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        CAM.transform.position = new Vector3(
            CAM.transform.position.x,
            CAM.transform.position.y,
            10);
    }
}
