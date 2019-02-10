using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursunKontrol : MonoBehaviour
{
    Rigidbody fizik;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*12;//transformun ilerisinde hareket etmesi için yazıldı.

    }
}
