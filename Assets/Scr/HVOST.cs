using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HVOST : MonoBehaviour
{
    public Transform BASHKA;
    public List<Transform> TELO = new List<Transform>();
    public List<Vector3> POS = new List<Vector3>();
    public float DIAM;

    void Start()
    {
        POS.Add(BASHKA.position);       
    }

    
    void Update()
    {
        float DIST = ((Vector3)BASHKA.position - POS[0]).magnitude;
        if (DIST>DIAM)
        {
            Vector3 DIR = ((Vector3)BASHKA.position - POS[0]).normalized;
            POS.Insert(0, POS[0]+DIR*DIAM);
            POS.RemoveAt(POS.Count-1);
            DIST -= DIAM;
        }
        for (int i=0; i < TELO.Count; i++)
        {
            TELO[i].position= Vector3.Lerp(POS[i + 1], POS[i],DIST/DIAM);
        }
    }
    public void TELOPLUS()
    {
        Transform KUSOK = Instantiate(BASHKA, POS[POS.Count-1],Quaternion.identity,transform);
        TELO.Add(KUSOK);
        POS.Add(KUSOK.position);
    }
    public void TELOMINUS()
    {
        Destroy(TELO[0].gameObject);
        TELO.RemoveAt(0);
        POS.RemoveAt(1);
    }
    
}
