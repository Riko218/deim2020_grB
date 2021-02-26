using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancescript : MonoBehaviour
{
    public GameObject SpaceShip;
    private SpaceshipMove spaceshipMove;
    public static float distance;
    public Text TextDistance;


    // Start is called before the first frame update
    void Start()
    {
       
        SpaceShip = GameObject.Find("nave");
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
        spaceshipMove.speed = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        TextDistance.text = "DISTANCIA: " + distancescript.distance.ToString("F0");
    }
}
