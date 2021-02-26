using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptYouDie : MonoBehaviour
{
    public float alphaLevel = 0f;
    public GameObject Youdie;
    public GameObject SpaceShip;
    public SpaceshipMove spaceshipMove;
    public Text TextPuntuacion;
    public static float distance;

    // Start is called before the first frame update
    void Start()
    {
        SpaceShip = GameObject.Find("nave");
        TextPuntuacion.text = "Puntuacion" + distance;


}

    // Update is called once per frame
    void Update()
    {
        
        alphaLevel++;
        Youdie.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel) * Time.deltaTime / 3;


    }
}
