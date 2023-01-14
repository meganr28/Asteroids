using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // public variables to tune Ship's movement
    public Vector3 forceVector;
    public float rotationSpeed;
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        // Vector3 default initializes all components to 0.0f
        forceVector.x = 1.0f;
        rotationSpeed = 2.0f;
    }

    /* forced changes to rigid body physics parameters should be done through the FixedUpdate()
    method, not the Update() method
    */
    void FixedUpdate()
    {
        // force thruster
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            GetComponent<Rigidbody>().AddRelativeForce(forceVector);
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rotation += rotationSpeed;
            Quaternion rot = Quaternion.Euler(new Vector3(0, rotation, 0));
            GetComponent<Rigidbody>().MoveRotation(rot);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rotation -= rotationSpeed; 
            Quaternion rot = Quaternion.Euler(new Vector3(0, rotation, 0));
            GetComponent<Rigidbody>().MoveRotation(rot);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
