using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateObject : MonoBehaviour
{

    public Transform target;
    public float range = 2f;
    public float peurObj;
    private bool UsedObject = false;

    private Gamemanager gamemanager;

    public Animator animObject;


    public float waitTime = 1f;

    public string IntruTag = "Intrus";

    public AudioClip PlaySound;

    public GameObject UICercle;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = Gamemanager.s_Singleton;

        GetComponent<SoundManager>();

        animObject = GetComponent<Animator>();
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
        UpdateTarget();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    private void OnMouseDown()
    {
        Debug.Log("souris dessus");
        if (target != null && UsedObject == false)
        {
            Debug.Log("boo");
            if (SceneManager.GetActiveScene().name == "1-1")
            {
                gamemanager.PeurProgress += 0.5f;
                UsedObject = true;
            }
            else
            {
                gamemanager.PeurProgress += peurObj;
                UsedObject = true;
            }

            animObject.SetBool("AnimActive", true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.clip = PlaySound;
            audio.Play();

            gamemanager.animPeur.SetBool("PlayPeur", true);
            gamemanager.AnimPlaying = true;

            if(gameObject.tag == "ObjetDérivation" )
            {
                gamemanager.DerivationEnabed = 2f;
            }
        }
        else
        {
            Debug.Log(target);
            Debug.Log(UsedObject);
        }
        if (UsedObject == false && target == null && gamemanager.Phase2 == true)
        {
            Debug.Log("intru dedans");
            UsedObject = true;
            animObject.SetBool("AnimActive", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            audio.clip = PlaySound;
            audio.Play();
            return;

        }
        else
        {
            return;
        }

    }

    private void OnMouseEnter()
    {
        UICercle.SetActive(true);
    }
    private void OnMouseExit()
    {
        UICercle.SetActive(false);
    }
    private void OnMouseOver()
    {
        
    }
}