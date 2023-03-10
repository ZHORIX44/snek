using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    
    public float Health;
    public Text ZZ;
    public Gradient gradient;
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
    public Material material5;
    public Material material6;
    public Material material7;
    public Material material8;
    public Material material9;
    public Material material10;
    public Material material11;
    public Material material12;
    public Material material13;
    public Material material14;
    public Material material15;
    public Material material16;
    public Material material17;
    public Material material18;
    public Material material19;
    public Material material20;
    public Material material21;
    public Material material22;
    public float MaxHP = 40;
    public Color C1;
    public Color C2;
    public GameObject CUBIK;
    public void CubeColor()
    {   
               
    }
    public void Update()
    {
        if (Health == 1)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material1;
        }
        if (Health == 2)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material2;
        }
        if (Health == 3)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material3;
        }
        if (Health == 4)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material4;
        }
        if (Health == 5)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material5;
        }
        if (Health == 6)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material6;
        }
        if (Health == 7)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material7;
        }
        if (Health == 9)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material9;
        }
        if (Health == 10)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material10;
        }
        if (Health == 11)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material11;
        }
        if (Health == 12)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material12;
        }
        if (Health == 13)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material13;
        }
        if (Health == 14)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material14;
        }
        if (Health == 15)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material15;
        }
        if (Health == 16)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material16;
        }
        if (Health == 17)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material17;
        }
        if (Health == 18)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material18;
        }
        if (Health == 19)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material19;
        }
        if (Health == 20)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material20;
        }
        if (Health == 21)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material21;
        }
        if (Health == 8)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material8;
        }




        if (Health == 22)
        {
            CUBIK.GetComponent<MeshRenderer>().material = material22;
        }
        ZZ.text = Health.ToString();
        if (Health == 0)
        {
            Destroy(gameObject);
        }
       //CubeColor();
    }
}
