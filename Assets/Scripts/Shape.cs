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

    private void OnMouseDown()
    {
        Push();
        ChangeColor();
    }

    // ENCAPSULATION
    public void SetForce(int force)
    {
        this.force = Mathf.Abs(force);
    }

    // ENCAPSULATION
    public int GetForce()
    {
        return force;
    }

    protected abstract void Push();

    private void ChangeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
    
}
