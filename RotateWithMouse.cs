using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{

    public float rotationSpeed;


    private void OnMouseDrag()
    {
        float Y = Input.GetAxis("Mouse Y") * rotationSpeed;
        float X = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.right, Y); // py�ritys X -akselin ymp�ri
        transform.Rotate(Vector3.up, -X);   // py�ritys Y -akselin ymp�ri
    }
}