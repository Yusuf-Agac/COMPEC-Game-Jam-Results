using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VoteAmount : MonoBehaviour
{

    public int myVote = 0;
    public int enemyVote = 0;
    private float startTime=1000000;
    private float time = 0;
    public bool win = false;
    public bool lose = false;
    public Text text;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = myVote.ToString();
        text2.text = enemyVote.ToString();
        if (myVote >= 51 && !lose)
            SceneManager.LoadScene("happy");

        if (enemyVote >= 51 && !win)
            SceneManager.LoadScene("sad");


        time = Time.time - startTime;
        if(time > 4)
        {
            enemyVote++;
            startTime = Time.time;
        }
    }
}
