using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Alan Escalante Galvan
//Equipo "Asesinos Imperiales"

public class Eliminar_Carretera : MonoBehaviour
{
	public GameObject camino;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "coche")
		{
			Destroy(camino, 1.0f);
		}
	}
}
