using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureScript : MonoBehaviour
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
        rend = GetComponent<Renderer>();
        UIImagen = GameObject.Find("PowerImage").GetComponent<Image>();
    }

    void Update()
    {
        float offset = Time.time * spaceshipMove.speed / 4;
        rend.material.mainTextureOffset = new Vector2(0, offset);

        if(spaceshipMove.speed == 2)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 1");
        }
        if (spaceshipMove.speed == 4)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 2");
        }
        if (spaceshipMove.speed == 8)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 3");
        }
        if (spaceshipMove.speed == 10)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Sprites/power 4");
        }
    }
}

