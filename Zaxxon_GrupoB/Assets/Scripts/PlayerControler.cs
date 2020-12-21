using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    //Variable de tipo animator que contendrá los parámetros
    [SerializeField] Animator playerControler;


    void Start()
    {
        //Asocio el componente Animator a la variable creada para ello
        playerControler = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Si pulso la barra espaciadora lanzo el trigger "Jump"
        if(Input.GetKeyDown("space"))
        {
            //Antes de lanzarlo, pongo la booleana jumping en "true"
            playerControler.SetBool("Jumping", true);
            playerControler.SetTrigger("Jump");

        }
        //Si pulso el cursor hacia abajo, el parámetro jumping se pone en false
        if(Input.GetKeyDown("down"))
        {
            playerControler.SetBool("Jumping", false);
        }


    }
}
