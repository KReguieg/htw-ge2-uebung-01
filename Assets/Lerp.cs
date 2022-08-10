using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;

    [Range(0f, 1f)]
    [SerializeField] private float t = 0;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.Lerp(Color.red, Color.blue, this.t);
        Gizmos.DrawLine(this.start.position, this.end.position);
        
        Vector3 lerpPos = Vector3.Lerp(this.start.position, this.end.position, this.t);

        Gizmos.DrawSphere(lerpPos, 0.1f);
    }
}
