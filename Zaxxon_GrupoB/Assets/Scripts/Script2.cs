using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    private float speed;
    //public Script1 ClaseCubo;

    public GameObject Cubo;
    private Script1 script1;

    // Start is called before the first frame update
    void Start()
    {
        script1 = Cubo.GetComponent<Script1>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = script1.speed / 2;
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        script1.SendMessage("UpdateText", speed.ToString());
        print(script1.speed);
    }
}
