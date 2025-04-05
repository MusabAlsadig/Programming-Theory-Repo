using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
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
        rigidbody.AddForce(transform.up * force, ForceMode.VelocityChange);
    }
}
