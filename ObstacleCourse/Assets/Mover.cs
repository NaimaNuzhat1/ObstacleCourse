using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed = 3.0f; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime *moveSpeed;

        transform.Translate(xValue,0, zValue);
    }
}
