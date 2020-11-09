using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook : MonoBehaviour
{
    [SerializeField] Transform Tarjet;
    private Vector3 camaraVelocity;
    private float smoothVelocity = 0.6f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(Tarjet.position.x, Tarjet.position.y +0.8f, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
