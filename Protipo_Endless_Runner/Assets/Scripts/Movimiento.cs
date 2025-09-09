using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Leonardo Aguirre Muñoz
//Equipo "Asesinos Imperiales"

public class Movimiento : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
    rb= this.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal= Input.GetAxis("Horizontal");
        float movVertical= Input.GetAxis("Vertical");
        Vector3 mov=new Vector3(movHorizontal,0,movVertical);
        rb.AddForce(mov*velocidad);
    }
}
