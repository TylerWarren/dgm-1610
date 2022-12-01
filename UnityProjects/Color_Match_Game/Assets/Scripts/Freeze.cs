using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0; // Freeze Time
    }

    void Update()
    {
        Time.timeScale = 1;
    }
}
