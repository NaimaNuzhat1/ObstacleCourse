using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{   
    int hits=0;
    private void OnCollisionEnter(Collision collider)
    {
        Debug.Log("You bumped into an object this many times:"+hits++);
        
    }
}
