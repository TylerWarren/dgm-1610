using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDelate : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            print ("Itam picked up");
            Destroy (gameObject);
             //Time.timeScale = 0;
        }
    }
} 

