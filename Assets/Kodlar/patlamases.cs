using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlamases : MonoBehaviour
{
    AudioSource ses;
    void Start()
    {
        ses = gameObject.GetComponent<AudioSource>();
    }

    public void patlamaSound(int x)
    {
        switch (x)
        {
            case 1: ses.clip = Resources.Load<AudioClip>("explosion_asteroid"); break;
            case 2: ses.clip = Resources.Load<AudioClip>("explosion_player"); break;

        }
        ses.Play();
    }
}
