using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Alan Escalante Galvan
//Equipo "Asesinos Imperiales"

public class Avance_Carretera : MonoBehaviour
{

    public float speed;
    public GameObject adminObj;
    public int dificultad;
    public int temp;
    // Start is called before the first frame update
    void Start()
    {
        dificultad = adminObj.GetComponent<Admin>().dificultadGlobal;
        temp = dificultad;
    }

    // Update is called once per frame
    void Update()
    {
        dificultad = adminObj.GetComponent<Admin>().dificultadGlobal;
        if (dificultad > temp)
        {
            speed += 5;
            temp = dificultad;
        }
        this.transform.Translate(Time.deltaTime * speed, 0, 0);
    }
}
