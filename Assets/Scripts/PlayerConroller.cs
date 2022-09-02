using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float speed;
    public float speedX;
    public float turnSpeed;
    private float horizontalInput ;
    private float verticalInput ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // move the playr forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed *  horizontalInput* turnSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput* speedX);
        // rotate the playr on horizontal input
        // transform.Rotate(Vector3.up, turnSpeed * verticalInput * Time.deltaTime);

    }
}
