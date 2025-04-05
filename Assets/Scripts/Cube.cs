using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public void SetForce(int force)
    {
        this.force = Mathf.Abs(force);
    }

    public int GetForce()
    {
        return force;
    }

    protected override void Pushup()
    {
        rigidbody.AddForce(transform.up * force, ForceMode.Acceleration);
    }
}
