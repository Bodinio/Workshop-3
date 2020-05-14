using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    private bool Phase2;

    void clickdroit()
    {
        transform.Rotate(0, 90, 0);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Phase2 = true;
        }
    }

    private void OnMouseDown()
    {
        if (Phase2 == true)
        {
            return;
        }
            clickdroit(); 
    }


}