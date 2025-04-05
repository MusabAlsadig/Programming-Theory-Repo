using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected MeshRenderer meshRenderer;

    [SerializeField]
    protected Rigidbody rigidbody;

    [SerializeField]
    protected int force;

    protected abstract void Pushup();
}
