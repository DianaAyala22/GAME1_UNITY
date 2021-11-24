using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avance : MonoBehaviour
{
    public float Velocidad = 10;
    public float Horizontal = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.forward*Time.deltaTime*Velocidad); 
       transform.Translate(Vector3.left*Time.deltaTime*5*Horizontal); 
       /*if (transform.position.x < 0.5) 
       {
           transform.position = new Vector3(0.5, transform.position.y, transform.position.z);
       }

       if(transform.position.x > 3)
       {
           transform.position = new Vector3(3, transform.position.y, transform.position.z);
       }*/
    }
}