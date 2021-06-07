using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarController : MonoBehaviour
{
    //variables
    
    private float speed = 25.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        


        //Move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
