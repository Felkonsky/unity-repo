using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private float time = 0.0f;
    private float waittime = 2.0f;
        public GameObject targetObj; 

    void Start()
    {
        targetObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
    
    
    void Update()
    {
        time += Time.deltaTime;
        
        if (time > waittime)
        {
            targetObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            time = 0.0f;
        }
        
    }
}
