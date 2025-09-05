using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Remover_Obstaculo : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="obstaculo"){
			Destroy(collision.gameObject);
		}
	}
}
