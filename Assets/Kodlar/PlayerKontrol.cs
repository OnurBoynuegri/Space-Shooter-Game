using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float minX, maxX,minZ,maxZ,egim,ateszamani,atesZamanlama;
    public GameObject kursun;
    public Transform kursunCikisYer;
    AudioSource ses;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        ses = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>ateszamani)
        {
            ateszamani = Time.time + atesZamanlama;
            Instantiate(kursun,kursunCikisYer.position,Quaternion.identity);
            ses.clip = Resources.Load<AudioClip>("weapon_player");
            ses.Play();
        }   
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal,0,vertical);
        fizik.velocity=vec*7;
        fizik.position = new Vector3(Mathf.Clamp(fizik.position.x, minX, maxX),0.0f, Mathf.Clamp(fizik.position.z, minZ, maxZ));
        //23.satırdaki kod nesnenin ekrandan çıkmaması için yazıldı.
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-egim);//nesne sağa ve sola giderken ucunun o yönlere eğilmesini sağlar.

    }
}
