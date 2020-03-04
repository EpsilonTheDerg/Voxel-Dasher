using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRotate : MonoBehaviour
{

    public float rotSpeed = -250;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Just logging time
        float angleRot = rotSpeed * Time.deltaTime;

        // Rotation application
        transform.Rotate(Vector3.up * angleRot);
    }
}
