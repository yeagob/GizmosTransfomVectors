using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    //Public Attribtes
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed = 1;

    //Private Attribtes
    private Vector3 _directionVector;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Cálculo del vector direccion
        _directionVector = finalTransform.position - initialTransform.position;

        //Convierte el vector en unitario
        _directionVector.Normalize();

        //Dibujamos el vector
        Debug.DrawRay(initialTransform.position, _directionVector * speed);

        //Traslate
        initialTransform.Translate(_directionVector * Time.deltaTime * speed);

        //Magnitude
        print("Magnitude: " + _directionVector.magnitude * speed);

        //Distance
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " + distance);
        if (distance < 10 || distance > 20)
            speed *= -1;
        
    }
}
