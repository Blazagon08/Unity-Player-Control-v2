using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Rotate(Vector3.back,  rotationSpeed * Time.deltaTime);
    }
}
