using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private float distanceToCamera;
    private float YOrig;

    private void Start()
    {
        distanceToCamera = Camera.main.transform.position.y - transform.position.y;
        YOrig = transform.position.y;
    }

    void OnMouseDrag()
    {

        Vector3 temp = Input.mousePosition;
        temp.z = distanceToCamera;
        Vector3 tmpPos = Camera.main.ScreenToWorldPoint(temp);
        tmpPos.y = YOrig;
        transform.position = tmpPos;

    }

}