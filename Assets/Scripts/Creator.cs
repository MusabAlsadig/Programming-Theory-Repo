using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField]
    private Shape[] shapes;

    private void Awake()
    {
        CreateRandomObject();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateRandomObject();
        }
    }

    // High level method for abstraction
    // ABSTRACTION
    private void CreateRandomObject()
    {
        Vector3 positon = transform.position;
        positon.x += Random.Range(-8, 8);

        Shape selectedShape = shapes[Random.Range(0, shapes.Length)];

        Instantiate(selectedShape, positon, Quaternion.identity);
    }

}
