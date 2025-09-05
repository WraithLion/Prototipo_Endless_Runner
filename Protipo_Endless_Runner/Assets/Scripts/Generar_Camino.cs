using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Generar_Camino : MonoBehaviour
{
	public GameObject camino;
	public Transform generar;
	
	private void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="coche"){
			Instantiate(camino,generar.position,this.transform.rotation);
		}
	}

}
