﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    //Creamos la variable a la que se moverá el obtáculo
    //Este valor deberá depender de la velocidad de la nave
    public float obstacleSpeed;

    public GameObject SpaceShip;
    public SpaceshipMove spaceshipMove;
     

    // Start is called before the first frame update
    void Start()
    {
        SpaceShip = GameObject.Find("nave");
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Comprobamos si la instancia ha rebasado a la nave y la destruimos
        //NOTA: habría que pasar esto a una CORRUTINA para consumir menos recursos
        float PosZ = transform.position.z;
        if(PosZ < -12)
        {
            Destroy(gameObject);
        }

        //Asignamos una velocidad fija (de momento)
        obstacleSpeed = spaceshipMove.speed;
        transform.Translate(Vector3.back * Time.deltaTime * obstacleSpeed);
        
       

    }
}
