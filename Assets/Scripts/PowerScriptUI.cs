using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerScriptUI : MonoBehaviour
{
    // Scroll the main texture based on time


    Renderer rend;
    public GameObject SpaceShip;
    public SpaceshipMove spaceshipMove;
    public Image UIImagen;


    void Start()
    {
        SpaceShip = GameObject.Find("nave");
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
        UIImagen = GameObject.Find("PowerImage").GetComponent<Image>();
    }

    void Update()
    { 
        if (spaceshipMove.speed >= 2)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 1");
        }
        if (spaceshipMove.speed >= 4)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 2");
        }
        if (spaceshipMove.speed >= 8)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 3");
        }
        if (spaceshipMove.speed >= 10)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 4");
        }
    }
}