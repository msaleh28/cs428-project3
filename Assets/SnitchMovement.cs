using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnitchMovement : MonoBehaviour
{

    float timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;


        // world position {"position":{"x":-11.528291702270508,"y":-0.6820815205574036,"z":-0.9200000762939453},"rotation":{"x":-0.7071068286895752,"y":0.0,"z":0.0,"w":0.7071068286895752},"scale":{"x":3.359999895095825,"y":3.359999895095825,"z":3.359999895095825}}
        float x = (Mathf.Cos(timeCounter) - 11.5f);
        float y = 1f;
        float z = Mathf.Sin(timeCounter);

        transform.position = new Vector3(x,y,z);
    }
}
