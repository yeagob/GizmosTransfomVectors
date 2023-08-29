using UnityEngine;

public class Espacio : MonoBehaviour
{
    //Atributes
    //Public  
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedZ;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;

    //Private  
    public float rotationAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento en 2 ejes
        //playerTransform.Translate(0, Time.deltaTime * speedY, Time.deltaTime * speedZ);

        //Movimiento en 2 ejes
        playerTransform.Translate(Vector3.forward * Time.deltaTime * speedZ);//Time.deltaTime = 1 / FPS
        playerTransform.Translate(Vector3.up * Time.deltaTime * speedY);

        //Rotación en 1 eje
        //playerTransform.Rotate(speedRotation * Time.deltaTime, 0, 0);
        playerTransform.Rotate(Vector3.right * speedRotation * Time.deltaTime);

        //Rotate Arround
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, rotationAngle * Time.deltaTime * speedRotationSphere);

        rotationAngle++;
    }
}
