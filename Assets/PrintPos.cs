using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position + " local: " + transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
