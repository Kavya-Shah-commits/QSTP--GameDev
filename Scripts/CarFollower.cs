using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{
    public Transform CarTransform;
    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        cameraTransform.position = new Vector3(CarTransform.position.x,CarTransform.position.y,-10f);
    }
}
