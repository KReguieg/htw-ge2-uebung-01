using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InverseLerp : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] private float innerRadius = 1.0f;
    [Range(0f, 10f)]
    [SerializeField] private float outterRadius = 2.0f;
    [SerializeField] private AudioSource audioSource = null;

    private void OnDrawGizmos()
    {
        Vector3 playerPos = transform.position;

        Handles.DrawWireDisc( Vector3.zero, Vector3.up, this.innerRadius);
        Handles.DrawWireDisc( Vector3.zero, Vector3.up, this.outterRadius);

        Gizmos.DrawSphere(playerPos, 0.05f);
        float distanceToPlayer = Vector3.Distance(playerPos, Vector3.zero);

        float audioVolume = Mathf.InverseLerp(this.outterRadius, this.innerRadius, distanceToPlayer);
        this.audioSource.volume = audioVolume;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(playerPos, playerPos + Vector3.up * audioVolume);
    }
}
