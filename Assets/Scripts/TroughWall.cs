using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TroughWall : MonoBehaviour
{
    public GameObject camera;
    public GameObject target;
    public LayerMask mylayermask;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(camera.transform.position, (target.transform.position - camera.transform.position) * 5, Color.red);

        if (Physics.Raycast(camera.transform.position, (target.transform.position - camera.transform.position).normalized, out hit, Mathf.Infinity, mylayermask))
        {
            if (hit.collider.gameObject.tag == "sphereMask")
            {
                target.transform.DOScale(0, 2);
            }
            else
            {
                target.transform.DOScale(10, 2);
            }
        }
        
    }
 
}
