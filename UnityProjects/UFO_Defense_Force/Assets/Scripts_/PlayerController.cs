using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Set horizontalInput to recive values from keybord
       horizontalInput = Input.GetAxis("Horizantal");

    // Moves Player left and right
       transfrom.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}