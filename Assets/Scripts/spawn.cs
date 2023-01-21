using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject cubeObj;
    public GameObject sphereObj;

    void Start()
    {
        InvokeRepeating("SpawnCube", 0.0f, 1.0f);
        InvokeRepeating("SpawnCube", 0.5f, 1.0f);
    }

    void SpawnCube()
    {
        Instantiate(cubeObj);
        Instantiate(sphereObj);
    }
}
