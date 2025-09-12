using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Alan Escalante Galvan
//Equipo "Asesinos Imperiales"

public class UpdateMovement : MonoBehaviour
{
	public float speed, rotationSpeed;
	public float vm, hm, disparo;
	// Update is called once per frame
	void Update()
	{
		//Almacena el boton de entrada para moverse a los lados izquierdo y derecho
		hm = Input.GetAxis("MoverseLados");

		//Actualiza su posición si se mueve a la izquierda o derecha.
		this.transform.Translate(Time.deltaTime * speed * hm, 0, 0);
	}
}
