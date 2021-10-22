using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering trigger= " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in trigger= " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting trigger= " + other.name);
    }
}
