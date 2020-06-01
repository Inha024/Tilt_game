using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
     if (other.name == "Goal")
        {
            Destroy(gameObject, .4f);
            Debug.Log("You Win!");
        }

    }
}

