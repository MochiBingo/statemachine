using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotateSpeed = 150;

    void Update()
    {
        float rotationAmount = Time.deltaTime * rotateSpeed;
        transform.Rotate(rotationAmount, rotationAmount, rotationAmount);
    }
}
