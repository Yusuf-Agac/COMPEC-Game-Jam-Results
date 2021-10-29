using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static AudioClip pringSound, cat, bgMusic;
    public static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        pringSound = Resources.Load<AudioClip>("pring");
        cat = Resources.Load<AudioClip>("cat");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "pringSound":
                audioSrc.PlayOneShot(pringSound);
                break;
            case "cat":
                audioSrc.PlayOneShot(cat);
                break;
        }
    }
}
