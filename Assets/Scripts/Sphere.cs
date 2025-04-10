using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE 
public class Sphere : Shape
{
    // POLYMORPHISM
    protected override void Push()
    {
        Vector3 forceDirection = GetDirectionAwayFromCamera();
        rigidbody.AddForce(forceDirection * force, ForceMode.Acceleration);
    }

    private Vector3 GetDirectionAwayFromCamera()
    {
        Transform cameraTransform = Camera.main.transform;
        Vector3 direction = transform.position - cameraTransform.position;
        return direction.normalized;
    }
}
