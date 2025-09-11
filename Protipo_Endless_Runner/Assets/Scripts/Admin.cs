using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Admin : MonoBehaviour
{
    public int dificultadGlobal;
    public TextMeshProUGUI textoDificultad;

    private void Start()
    {
        StartCoroutine(SubirDificultad());
    }

    void Update()
    {
        textoDificultad.text = dificultadGlobal.ToString();
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
