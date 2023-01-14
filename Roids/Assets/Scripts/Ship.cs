using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // public variables to tune Ship's movement
    public float turnSpeed;
    public float thrustSpeed;

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = .5f; thrustSpeed = .01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            gameObject.transform.Translate(0, 0, thrustSpeed);
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            gameObject.transform.Rotate(0, turnSpeed, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            gameObject.transform.Rotate(0, -turnSpeed, 0);
        }
    }
}
