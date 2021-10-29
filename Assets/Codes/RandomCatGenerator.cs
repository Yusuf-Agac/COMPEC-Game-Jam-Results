using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCatGenerator : MonoBehaviour
{
    public GameObject Cat;

    private Vector3 GenerationPos;
    public float HaritaX = 4;
    public float HaritaY = 2;
    [SerializeField]
    public int CatCounter = 0;
    public int maksCat = 1;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        GenerationPos = new Vector3(Random.Range(-HaritaX, HaritaX), Random.Range(-HaritaY, HaritaY), 0);
        if (CatCounter < maksCat)
            Generator();
    }

    public void Generator()
    {
        GameObject cat = Instantiate(Cat, GenerationPos, Quaternion.identity);
        CatCounter++;
    }
}
