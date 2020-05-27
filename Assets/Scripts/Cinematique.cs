using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematique : MonoBehaviour
{
    public Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();

    }


    void Update()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Vous avez cliqué");
                anim.SetBool("Transition", true);
            }

        }

    }
}