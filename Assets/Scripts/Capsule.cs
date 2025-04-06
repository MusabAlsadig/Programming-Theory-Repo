using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
    // POLYMORPHISM
    protected override void Push()
    {
        rigidbody.AddForce(transform.up * force);
    }
}
