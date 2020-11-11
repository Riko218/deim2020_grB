using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public float speed;

    [SerializeField] Text SpeedText;

    //GameObject con el prefab
    [SerializeField] GameObject MyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        Instantiate(MyPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        
    }

    public void UpdateText(string texto)
    {
        SpeedText.text = texto;
    }
}
