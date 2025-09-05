using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class UpdateMovement : MonoBehaviour
{
	public float speed, rotationSpeed;
	public float vm,hm;

    // Update is called once per frame
    void Update()
    {
	vm=Input.GetAxis("Vertical");
	hm= Input.GetAxis("Horizontal");

	this.transform.Translate(Time.deltaTime*speed*hm,0,0);
	//this.transform.Rotate(Vector3.up,rotationSpeed*Time.deltaTime*hm);    
    }
}
