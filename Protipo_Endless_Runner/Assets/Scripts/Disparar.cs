using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bala;
    public Transform puntoDisparo;
    public int Calor;

    void Update()
    {
        if (Input.GetKeyDown("space") && Calor < 5)
        {
            DispararBala();
        }
        }

    void Start()
    {
        StartCoroutine(EnfriarCalor());
    }

    IEnumerator EnfriarCalor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (Calor > 0)
            {
                Calor -= 1;
            }
        }
    }

    void DispararBala()
    {
        GameObject nuevaBala = Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation);
        Calor += 1;
        nuevaBala.GetComponent<Rigidbody>().velocity = puntoDisparo.forward * 15f;
        Destroy(nuevaBala, 3f);
    }
}
