using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin : MonoBehaviour
{
    public int dificultadGlobal;
    private void Start()
    {
        StartCoroutine(SubirDificultad());
    }

    private IEnumerator SubirDificultad()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            dificultadGlobal += 1;
        }
    }
}
