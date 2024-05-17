using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float timeToWait= 5f;
    MeshRenderer renderer;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true; 
            renderer.enabled = true;
        }
    }
}
