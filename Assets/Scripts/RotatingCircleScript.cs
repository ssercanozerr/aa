using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCircleScript : MonoBehaviour
{
    public float rotatingSpeed;
    void Update()
    {
        transform.Rotate(0, 0, rotatingSpeed * Time.deltaTime);
    }
}
