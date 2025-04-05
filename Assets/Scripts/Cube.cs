using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    protected override void Pushup()
    {
        rigidbody.AddForce(transform.up * force, ForceMode.Acceleration);
    }
}
