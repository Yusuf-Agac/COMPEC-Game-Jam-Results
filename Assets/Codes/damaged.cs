using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damaged : MonoBehaviour
{
    private Animator anim;
    private float startTime = 100000;
    public GameObject fireLight;
    public GameObject Lig1;
    public GameObject Lig2;
    public GameObject tus;
    public bool oyCalabilirsin = false;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Time.time - startTime > 5)
        {
            anim.SetBool("broke", false);
            fireLight.SetActive(false);
            Lig1.SetActive(true);
            Lig2.SetActive(false);
            tus.SetActive(false);
            oyCalabilirsin = false;
        }
    }

    public void damagedLook()
    {
        anim.SetBool("broke", true);
        fireLight.SetActive(true);
        Lig1.SetActive(false);
        Lig2.SetActive(true);
        tus.SetActive(true);
        oyCalabilirsin = true;
        startTime = Time.time;
    }
}
