using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Generar_Obstaculos : MonoBehaviour
{
	public GameObject[] obstaculos=new GameObject[4];
	public GameObject[] barreras=new GameObject[4];
	int s,c;

    // Start is called before the first frame update
    void Start()
    {
	
	for(int i=0; i<4;i++){
		s= Random.Range(0,4);
		c= Random.Range(0,4);	
		Instantiate(barreras[c],obstaculos[s].transform.position, obstaculos[s].transform.rotation);
	}
	
        
    }

}
