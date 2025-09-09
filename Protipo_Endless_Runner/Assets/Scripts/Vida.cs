using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vida : MonoBehaviour
{

    public int vida = 3;
    public float puntos;
    public float tiempo;
    public TMP_Text vidaText;
    public TMP_Text puntosText;
    public GameObject gameOverUI;

    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 10.0f)
        {
            puntos += 1.0f;
            tiempo = 0;
        }
        vidaText.text = vida.ToString();
        puntosText.text = puntos.ToString();
        if (vida <= 0)
        {
            gameOverUI.SetActive(true);
            this.enabled = false;
            Time.timeScale = 0;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstaculo")
        {
            vida--;
            Destroy(collision.gameObject);
        }
    }
}
