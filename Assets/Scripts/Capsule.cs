using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{

    protected override void Push()
    {
        rigidbody.AddForce(transform.up * force);
    }
}
