using UnityEngine;

public class Circle : MonoBehaviour
{
    float rotationSpeed = 100F;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0F, 0F, rotationSpeed * Time.deltaTime);
    }
}
