using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{

    private float sideForce = 15.0f;
    private float upForce = 15.0f;

    [SerializeField]private float rotationForce = 180f;


    // Start is called before the first frame update
    void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(0, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        float xRotation = Random.Range(-rotationForce, rotationForce);
        float yRotation = Random.Range(-rotationForce, rotationForce);
        float zRotation = Random.Range(-rotationForce, rotationForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);
        Vector3 rotation = new Vector3(xRotation, yRotation, zRotation);
        GetComponent<Rigidbody>().velocity = force;
        GetComponent<Rigidbody>().angularVelocity = rotation;
    }

    void update()
    {
        // change color here i guess
    }
    

}
