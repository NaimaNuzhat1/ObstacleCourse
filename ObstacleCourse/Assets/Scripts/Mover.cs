using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed = 8.0f; 
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move you player with WASD or arrow keys");
        Debug.Log("Dont hit the walls!");
    }
    void PlayerMovement()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
