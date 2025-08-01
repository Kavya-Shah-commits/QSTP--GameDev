using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarContoller : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed, moveSpeed;
    public Transform carTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Debug.Log("Horizontal:"+ horizontalMovement + "vertical:" + verticalMovement);

        if(Mathf.Abs(horizontalMovement)> 0.01f)
        {
            carTransform.Rotate(0f,0f, -1 * rotationSpeed * horizontalMovement * Time.deltaTime);
        }
        if(Mathf.Abs(verticalMovement)> 0.01f)
        {
            carTransform.Translate(0f,moveSpeed * verticalMovement * Time.deltaTime,0f);
        }
    }
}
