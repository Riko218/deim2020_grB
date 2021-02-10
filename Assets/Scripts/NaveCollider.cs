using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;





public class NaveCollider : MonoBehaviour
{
    public Transform explosionPrefab;

    public GameObject SpaceShip;
    public SpaceshipMove spaceshipMove;
    public Component[] Renderizado;

    void Start()
    {
        SpaceShip = GameObject.Find("nave");
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        spaceshipMove.speed = 0f;
        Instantiate(explosionPrefab, position, rotation);
        
        Renderer[] rs = SpaceShip.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
            r.enabled = false;

        StartCoroutine(ActivateOnTimer());

        IEnumerator ActivateOnTimer ()
            {
            while (true)
            {
                yield return new WaitForSeconds(3f);

                SceneManager.LoadScene("Escena1");
            }
            
        }
        
    }

}


