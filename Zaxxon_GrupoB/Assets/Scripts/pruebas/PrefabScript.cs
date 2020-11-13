using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    private GameObject Cubo;
    private Script1 script1;

    // Start is called before the first frame update
    void Start()
    {
        Cubo = GameObject.Find("Cube");
        script1 = Cubo.GetComponent<Script1>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * script1.speed);
    }
}
