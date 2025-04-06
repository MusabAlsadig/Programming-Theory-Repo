using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void Push()
    {
        Vector3 forceDirection = GetRandomDirection();
        rigidbody.AddForce(forceDirection * force);
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3()
        {
            x = Random.Range(-1, 1),
            y = Random.Range(0.1f, 1),
            z = Random.Range(-1, 1),
        }.normalized;
    }
}
