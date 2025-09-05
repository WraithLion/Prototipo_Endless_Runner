using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Policias : MonoBehaviour
{
	public AudioClip audio;
	public AudioSource audioS;
	
    // Start is called before the first frame update
    private void Start()
    {
	audioS= this.GetComponent<AudioSource>();
    }

	private void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="coche"){
			audioS.PlayOneShot(audio);
			Destroy(this.gameObject,3);
}
}

}
