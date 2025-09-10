using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public int vida;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disparo"))
        {
            Destroy(other.gameObject);
            vida--;
            if (vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
