using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlatma : MonoBehaviour
{
    private const string Tag = "oyunkontrol";
    public GameObject patlama;
    public GameObject PlayerPatlama;
    GameObject OyunKontrol,patlamases;
    OyunKontrol kontrol;
    patlamases pses;
    
    private void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");//oyunkontrol nesnesi prefab olmadığı için sürükle bırak ile 
        //burada oluşturduğumuz nesneye atama yapamadık bunu yapabilmek için bu kodu kullandık
        patlamases = GameObject.FindGameObjectWithTag("PATLAMASES");
        kontrol = OyunKontrol.GetComponent<OyunKontrol>();
        pses = patlamases.GetComponent<patlamases>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "sinir")
        {
            Destroy(other.gameObject);//yazılan nesneye çarpan nesneyi yokeder.
            Destroy(gameObject);//bu kod yazılan nesneyi yok eder.
            pses.patlamaSound(1);
            kontrol.scoreSay(10);
            Instantiate(patlama, transform.position, transform.rotation);
            
        }

        if (other.tag == "Player")
        {
            pses.patlamaSound(2);
            Instantiate(PlayerPatlama, other.transform.position, other.transform.rotation);//oyuncu patladığında patlama efekti çıkarır.
            kontrol.gameover();
            
        }
    }
} 
