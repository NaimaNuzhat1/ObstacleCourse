using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collider)
    {
        Debug.Log("Bumped into a wall!");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

