using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.LookAt(target.transform);
        transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);

    }
}
