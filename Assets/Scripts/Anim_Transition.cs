using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Transition : MonoBehaviour

{

    public Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
        /* void Update()
         {
             // Créer variable "PEUR" dans la jauge pour pouvoir trigger l'animation suivante.
             if (int PEUR >= 50)
         {
             anim.SetBool("Is_Stressed", true);
         }
         else
         {
             anim.SetBool("Is_Stressed =false", false);
         }

     }
             */
    }
}
