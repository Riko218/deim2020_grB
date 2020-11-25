using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_fisics : MonoBehaviour
{
    [SerializeField] Transform esfera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(esfera.position);
    }
}
