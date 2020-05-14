using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{

    public Transform target;
    public float range = 2f;
    private bool UsedObject = false;

    private Gamemanager gamemanager;

    public float waitTime = 1f;

    public string IntruTag = "Intrus";

    public AudioClip PlaySound;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.2f);
        
        gamemanager = Gamemanager.s_Singleton;

        GetComponent<SoundManager>();
    }

    void UpdateTarget()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag(IntruTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject Intru in ennemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, Intru.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = Intru;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    private void OnMouseDown()
    {
        if (target != null && UsedObject == false)
        {
            gamemanager.JaugePeur.fillAmount += 0.5f;
            UsedObject = true;

            
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.clip = PlaySound;
            audio.Play();
        }
        else
        {
            return;
        }

    }

}