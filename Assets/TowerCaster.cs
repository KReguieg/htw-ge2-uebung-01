using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TowerCaster : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        void DrawRay(Vector3 p, Vector3 dir) => Handles.DrawAAPolyLine(p, p + dir);

        Vector3 headPos = transform.position;
        Vector3 lookDirection = transform.forward;

        if (Physics.Raycast(headPos, transform.forward, out RaycastHit hit))
        {
            Vector3 hitPos = hit.point;
            Vector3 up = hit.normal;

            Handles.color = Color.blue;
            DrawRay(hitPos, up);

            //Vector3 right = Vector3.Cross(up, lookDirection).normalized;
            //Vector3 forward = Vector3.Cross(right, up);


            Handles.color = Color.green;
            DrawRay(headPos, hitPos);
        }
        else
        {
            Handles.color = Color.red;
            DrawRay(headPos, headPos + lookDirection);
        }
    }
}
