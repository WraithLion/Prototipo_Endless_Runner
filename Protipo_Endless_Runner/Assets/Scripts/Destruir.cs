using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disparo"))
        {
            Destroy(gameObject);
        }
    }
}
