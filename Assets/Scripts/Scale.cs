using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //Public Attributes
    public float scaleX;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        
    }
}
