using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Avance_Obstaculos : MonoBehaviour
{

	public float speed;

    // Update is called once per frame
    void Update()
    {
	this.transform.Translate(0,0,Time.deltaTime*speed);        
    }
}
