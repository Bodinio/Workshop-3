using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void clickdroit()
    {
        transform.Rotate(0, 90, 0);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            clickdroit();
        }
    }
}