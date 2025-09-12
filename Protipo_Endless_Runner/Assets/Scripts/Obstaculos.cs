using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Alan Escalante Galvan
//Equipo "Asesinos Imperiales"

public class Obstaculos : MonoBehaviour
{
	public AudioClip audio;
	public AudioSource audioS;

	// Start is called before the first frame update
	private void Start()
	{
		audioS = this.GetComponent<AudioSource>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "coche")
		{
			audioS.PlayOneShot(audio);
		}
	}

}
