using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_phisics : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Suelo")
        {
            print("Ha colisionado");
            Destroy(gameObject);
        }
        
    }

}
