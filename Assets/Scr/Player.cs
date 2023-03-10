using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody R;
    public int NAZAD;
    public int PHP;
    public Text PlayerHP;
    int TIMES=0;
    public GameObject LOST;
    public GameObject WIN;
    public GameObject WIN2;
    public GameObject PARTICLES;
    public GameObject PARTICLES2;
    public Vector3 TUT;
    public Quaternion RR;
    public AudioSource BUM;
    public AudioSource BUM2;
    public void VKUSNO()
    {
        Instantiate(PARTICLES2, TUT, RR);
    }
    private void Start()
    {
        R = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Kvadrat")
        {
            TUT = R.transform.position;
            PHP--;
            R.AddForce(NAZAD,0,0);
            collision.gameObject.GetComponent<HP>().Health--;
            Instantiate(PARTICLES,TUT,RR);
            this.gameObject.GetComponent<HVOST>().TELOMINUS();            
            if (collision.gameObject.GetComponent<HP>().Health <= 0)
            {
                BUM.Play();
                Destroy(collision.gameObject);
                Debug.Log(collision.gameObject);
            }
            if (PHP<= 0)
            {
                Destroy(R);
                Instantiate(LOST);
            }
        }
        if (collision.gameObject.tag == "Eda")
        {
            BUM2.time = 1.5f;
            BUM2.Play();
            TUT = R.transform.position;
            VKUSNO();
            int ABOBA = collision.gameObject.GetComponent<HPP>().Health;
            PHP = PHP + ABOBA;                  
                Destroy(collision.gameObject);
                Debug.Log(collision.gameObject);
            while (TIMES <= ABOBA)
            {
                this.gameObject.GetComponent<HVOST>().TELOPLUS();
                TIMES++;
            }
            TIMES = 0;
        }
        if (collision.gameObject.tag == "KONEC")
        {
            Instantiate(WIN);
        }
        if (collision.gameObject.tag == "KONECLAST")
        {
            Instantiate(WIN2);
        }
    }
    private void Update()
    {
        PlayerHP.text = PHP.ToString();      
    }
    
}
