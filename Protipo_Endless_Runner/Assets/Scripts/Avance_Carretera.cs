using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Avance_Carretera : MonoBehaviour
{

	public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	this.transform.Translate(Time.deltaTime*speed,0,0);        
    }
}
