using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawMath : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void OnDrawGizmos()
    {
        //this.DrawLineVectorRight();
        //this.DrawZeroToVector();
        //this.DrawNoramlizedVector();
        //this.DrawAndLogDistance();
        //this.DrawDirection();
        this.DrawObjectAtDistance();
    }

    private void DrawObjectAtDistance()
    {
        // How?
        Vector2 directionToEnemy = target.position - transform.position;
        Vector2 halfDistanceToEnemy = directionToEnemy / 2;
        float distance = Vector2.Distance(Vector2.zero, halfDistanceToEnemy);

        Gizmos.DrawSphere(halfDistanceToEnemy, 0.5f);
        if (distance <= 5f)
        {
            Debug.Log("ENEMY TO CLOOSE! BE CAREFUL!");
        }
    }

    private void DrawDirection()
    {
        Vector2 player = transform.position;

        // How was it again?
        Vector2 directionToTarget = new Vector2(target.position.x, target.position.y) - player;


        Gizmos.DrawLine(player, player + directionToTarget);
    }

    private void DrawAndLogDistance()
    {
        Vector2 endPoint = transform.position;

        float distance = Vector2.Distance(Vector2.zero, endPoint);

        Debug.Log("Distance= " + distance);

        float distanceToo = (Vector2.zero - endPoint).magnitude;

        Debug.Log("DistanceToo= " + distanceToo);

        double distanceTooToo = Math.Sqrt(Mathf.Pow(Vector2.zero.x - endPoint.x, 2) + Mathf.Pow(Vector2.zero.y - endPoint.y, 2));

        Debug.Log("DistanceTooToo= " + distanceTooToo);

        Gizmos.DrawLine(Vector2.zero, endPoint);

    }

    private void DrawNoramlizedVector()
    {
        Vector2 endPoint = transform.position;


        Gizmos.DrawLine(Vector2.zero, endPoint.normalized);
    }

    private void DrawLineVectorRight()
    {
        Vector2 ownVector = new Vector2(-1, -1);

        Gizmos.DrawLine(Vector2.zero, ownVector);
    }

    private void DrawZeroToVector()
    {
        Vector2 endPoint = transform.position;

        Gizmos.DrawLine(Vector2.zero, endPoint);
    }


}
