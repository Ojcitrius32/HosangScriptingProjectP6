using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This first line is going to tell mme the x location of my game object
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {

        //make a if statement thatr checks the hight of a object.
        if (transform.position.y <= 5f)
        {
            Debug.Log("i'm about to hit the ground");
        }
    }
}