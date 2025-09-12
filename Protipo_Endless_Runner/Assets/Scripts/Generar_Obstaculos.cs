using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Alan Escalante Galvan
//Equipo "Asesinos Imperiales"

public class Generar_Obstaculos : MonoBehaviour
{
	public GameObject[] obstaculos = new GameObject[4];
	public GameObject[] barreras = new GameObject[4];
	int c;
	int dificultad;
	int vida;
	int carril; // Variante de carril libre
	Vector3 mover = new Vector3(6, 0, 0); //Vector para reubicar obstaculos en eje X
	public GameObject adminObj;
	// Start is called before the first frame update
	void Start()
	{
		dificultad = adminObj.GetComponent<Admin>().dificultadGlobal;
		if (dificultad >= 2)
		{
			vida += dificultad - 1;
		}
		for (int i = 0; i < 4; i++)
		{
			c = Random.Range(0, 4); //Asignacion de un muro al azar.
									//Condicion si la iteracion es par para asignar un carril
			if (i % 2 == 0)
			{
				carril = Random.Range(1, 4); //Se elige al azar una de las tres variantes de carril
			}

			//Casos para asignar los obstaculos y dejar el carril lateral izquierdo libre.

			if (carril == 1 && i % 2 == 0)
			{
				GameObject obstaculonuevo = Instantiate(barreras[c], obstaculos[i].transform.position + mover, obstaculos[i].transform.rotation);
				obstaculonuevo.GetComponent<Destruir>().vida = vida;
			}
			if (carril == 1 && i % 2 == 1)
			{
				GameObject obstaculonuevo = Instantiate(barreras[c], obstaculos[i].transform.position, obstaculos[i].transform.rotation);
				obstaculonuevo.GetComponent<Destruir>().vida = vida;
			}
			//Caso para asignar los obstaculos y dejar el carril central libre.
			if (carril == 2)
			{
				GameObject obstaculonuevo1 = Instantiate(barreras[c], obstaculos[i].transform.position, obstaculos[i].transform.rotation);
				obstaculonuevo1.GetComponent<Destruir>().vida = vida;
			}
			//Casos para asignar los obstaculos y dejar el carril lateral derecho libre.
			if (carril == 3 && i % 2 == 0)
			{
				GameObject obstaculonuevo2 = Instantiate(barreras[c], obstaculos[i].transform.position, obstaculos[i].transform.rotation);
				obstaculonuevo2.GetComponent<Destruir>().vida = vida;
			}
			if (carril == 3 && i % 2 == 1)
			{
				GameObject obstaculonuevo2 = Instantiate(barreras[c], obstaculos[i].transform.position - mover, obstaculos[i].transform.rotation);
				obstaculonuevo2.GetComponent<Destruir>().vida = vida;
			}



		}
	}

}
