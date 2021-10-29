using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDayiGenerator : MonoBehaviour
{
    public GameObject dayi;
    public GameObject dayi2;
    private Vector3 GenerationPos;
    public float HaritaX = 4;
    public float HaritaY = 2;
    [SerializeField]
    public int dayiCounter = 0;
    public int maksDayi = 1;
    private float random;


    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0, 100);
        GenerationPos = new Vector3(Random.Range(-HaritaX, HaritaX), Random.Range(-HaritaY, HaritaY), 0);
        if (dayiCounter < maksDayi && random<50)
            Generator();
        else if (dayiCounter < maksDayi && random > 50)
            Generator2();
    }

    public void Generator()
    {
        GameObject cat = Instantiate(dayi, GenerationPos, Quaternion.identity);
        dayiCounter++;
    }
    public void Generator2()
    {
        GameObject cat = Instantiate(dayi2, GenerationPos, Quaternion.identity);
        dayiCounter++;
    }
}
