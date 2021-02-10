using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI; //Importante importar esta librería para usar la UI

public class SpaceshipMove : MonoBehaviour
{
    //--SCRIPT PARA MOVER LA NAVE --//

    //Variable PÚBLICA que indica la velocidad a la que se desplaza
    //La nave NO se mueve, son los obtstáculos los que se desplazan
    public float speed = 1;

    //Variable que determina cómo de rápido se mueve la nave con el joystick
    //De momento fija, ya veremos si aumenta con la velocidad o con powerUps
    private float moveSpeed = 5f;

    //Variable que determina si estoy en los márgenes
    private bool inMarginMoveX = true;
    private bool inMarginMoveY = true;
    

    //Capturo el texto del UI que indicará la distancia recorrida
    public Text TextDistance;
    [SerializeField] GameObject dist;

    



    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        //Llamo a la corrutina que hace aumentar la velocidad
        StartCoroutine("Distancia");
        dist.GetComponent<distancescript>();
        
}

    // Update is called once per frame
    void Update()
    {
        //Ejecutamos la función propia que permite mover la nave con el joystick
        MoverNave();
        
    }

    //Corrutina que hace cambiar el texto de distancia
    IEnumerator Distancia()
    {
        //Bucle infinito que suma 10 en cada ciclo
        //El segundo parámetro está vacío, por eso es infinito
        for(int n = 1; ; n ++)
        {
           
            distancescript.distance += n * speed * Time.deltaTime;
            //Cambio el texto que aparece en pantalla
            TextDistance.text = "DISTANCIA: " + distancescript.distance.ToString("F0");
            

            //Cada ciclo aumenta la velocidad con un limite de 10.
            if(speed >= 1)
                { speed = speed + 0.1f;
            }
            
            //Ejecuto cada ciclo esperando 0.1 segundo
            yield return new WaitForSeconds(0.1f);
        }
        
    }



    void MoverNave()
    {


        /*
        //Ejemplos de Input que podemos usar más adelante
        if(Input.GetKey(KeyCode.Space))
        {
            print("Se está pulsando");
        }
        if(Input.GetButtonDown("Fire1"))
        {
            print("Se está disparando");
        }
        */
        //Variable float que obtiene el valor del eje horizontal y vertical
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");

        //Movemos la nave mediante el método transform.translate
        //Lo multiplicamos por deltaTime, el eje y la velocidad de movimiento la nave

        //print(transform.position.x);
        float myPosX = transform.position.x;
        float myPosY = transform.position.y;
        

        //Lanzamos el método que nos comprueba la restricción en X y en Y
        checkRestrX(myPosX, desplX);
        checkRestrY(myPosY, desplY);

        //Si estoy en los márgenes, me muevo
        if (inMarginMoveX)
        {
            //Este codigo es de Iris para el movimiento y rotacion
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX, Space.World);
            transform.rotation = Quaternion.Euler(0, 0, desplX * -10);
        }
        if (inMarginMoveY)
        {
            //Este codigo es de Iris para el movimiento y rotacion
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY, Space.World);

        }

        
        

    }

    void checkRestrX(float myPosX, float desplX)
    {
        //Retricción en X
        if (myPosX < -4.5 && desplX < 0)
        {
            inMarginMoveX = false;
        }
        else if (myPosX < -4.5 && desplX > 0)
        {
            inMarginMoveX = true;
        }
        else if (myPosX > 4.5 && desplX > 0)
        {
            inMarginMoveX = false;
        }
        else if (myPosX > 4.5 && desplX < 0)
        {
            inMarginMoveX = true;
        }
    }

    void checkRestrY(float myPosY, float desplY)
    {
        //Retricción en Y
        if (myPosY < -0 && desplY < 0)
        {
            inMarginMoveY = false;
        }
        else if (myPosY < -0 && desplY > 0)
        {
            inMarginMoveY = true;
        }
        else if (myPosY > 4 && desplY > 0)
        {
            inMarginMoveY = false;
        }
        else if (myPosY > 4 && desplY < 0)
        {
            inMarginMoveY = true;
        }

    }

    }

