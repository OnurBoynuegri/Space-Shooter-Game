using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroitHareket : MonoBehaviour
{
    Rigidbody fizik;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * -3;//transformun ilerisinde hareket etmesi için yazıldı.

    }
}
