using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrdistancefinal : MonoBehaviour

{
    public Text TextDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextDistance.text = "Puntuación:   " + distancescript.distance.ToString("F0");
    }
}
