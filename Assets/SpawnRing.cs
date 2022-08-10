using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRing : MonoBehaviour
{
    [SerializeField] float fireCount;
    [SerializeField] GameObject fireObj;
    [SerializeField] Transform ringParent;

    float TAU = 2 * Mathf.PI;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < fireCount; i++)
        {
            float angleInTurns = i / fireCount;
            float angleInRadians = angleInTurns * this.TAU;

            float x = Mathf.Cos(angleInRadians);
            float y = Mathf.Sin(angleInRadians);

            GameObject.Instantiate(this.fireObj, new Vector3(x, 0, y) * 5, Quaternion.identity, this.ringParent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
