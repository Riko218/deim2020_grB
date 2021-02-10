using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancescript : MonoBehaviour
{
    public GameObject SpaceShip;
    public SpaceshipMove spaceshipMove;
    public static float distance = 0f;
    public Text TextDistance;


    // Start is called before the first frame update
    void Start()
    {
       
        SpaceShip = GameObject.Find("nave");
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
        spaceshipMove.speed = 0f;
        TextDistance.text = "Puntuacion" + distance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
