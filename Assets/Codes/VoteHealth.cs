using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoteHealth : MonoBehaviour
{
    public int health = 3;
    private VoteAmount vote;
    private RandomDayiGenerator gener;

    private void Start()
    {
        vote = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<VoteAmount>();
        gener = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<RandomDayiGenerator>();
    }

    public void takeVoteDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            gener.dayiCounter--;
            vote.myVote++;
            Destroy(this.gameObject);
        }
    }
}
