using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPaperGenerator : MonoBehaviour
{
    public GameObject Paper;

    private Vector3 GenerationPos;
    public float HaritaX = 4;
    public float HaritaY = 2;
    [SerializeField]
    public int PaperCounter = 0;
    public int maksPaper = 2;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        GenerationPos = new Vector3(Random.Range(-HaritaX, HaritaX), Random.Range(-HaritaY, HaritaY), 0);
        if (PaperCounter < maksPaper)
            Generator();
    }
    
    public void Generator()
    {
        GameObject paper = Instantiate(Paper, GenerationPos, Quaternion.identity);
        PaperCounter++;
    }
}
