using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject asteroid;
    public Vector3 RandomPos;
    int score;
    public Text text,oyunbittiText,YenidenbaslaText;
    bool oyunbittiKontrol = false;
    bool yenidenBasla = false;


    void Start()
    {
        score = 0;
        text.text = "Score = " + score;
        StartCoroutine(olustur());   
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && yenidenBasla)//klavyeden r girilme durumunu kontrol ediyor
        {
            SceneManager.LoadScene("level 1");// lever 1 adlı sahneyi tekrar yükler
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);//oyun başladıktan 2 saniye sonra while döngüsüne girdirmek için bu kod kullanıldı
        while (true)
        {
            if (oyunbittiKontrol)
            {
                yenidenBasla = true;
                YenidenbaslaText.text = "Tekrar denemek icin r'ye basin";
                break;

            }
                
            Vector3 vec = new Vector3(Random.Range(-RandomPos.x, RandomPos.x), 0, RandomPos.z);
            Instantiate(asteroid, vec, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
    public void scoreSay(int GelenScore)
    {
        score += GelenScore;
        text.text = "Score = " + score;
    }

    public void gameover()
    {
        oyunbittiText.text = "Game Over";
        oyunbittiKontrol = true;
    }
    
}
