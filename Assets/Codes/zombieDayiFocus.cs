using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieDayiFocus : MonoBehaviour
{
    private GameObject sandik;
    private Vector3 sandikPos;
    public LayerMask sandikLayer;
    private VoteAmount vote;
    private RandomDayiGenerator gener;
    public float speed = 0.01f;
    public float speedEks = 250f;

    // Start is called before the first frame update
    void Start()
    {
        sandik = GameObject.FindGameObjectWithTag("sandik");
        vote = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<VoteAmount>();
        gener = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<RandomDayiGenerator>();
        sandikPos = sandik.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] sandik = Physics2D.OverlapCircleAll(transform.position, 0.5f, sandikLayer);

        foreach (Collider2D sandiklar in sandik)
        {
            vote.enemyVote++;
            gener.dayiCounter--;
            Destroy(this.gameObject);
        }

        if(transform.position.x > sandikPos.x && Mathf.Abs(transform.position.x - sandikPos.x) > 0.3f)
        {
            transform.position += new Vector3(-Mathf.Abs(transform.position.x - sandikPos.x) / speedEks -speed, 0, 0);
        }
        else if(transform.position.x < sandikPos.x && Mathf.Abs(transform.position.x - sandikPos.x) > 0.3f)
        {
            transform.position += new Vector3(Mathf.Abs(transform.position.x - sandikPos.x) / speedEks + speed, 0, 0);
        }

        if (transform.position.y > sandikPos.y && Mathf.Abs(transform.position.y - sandikPos.y) > 0.3f)
        {
            transform.position += new Vector3(0, -Mathf.Abs(transform.position.y - sandikPos.y) / speedEks - speed, 0);
        }
        else if (transform.position.y < sandikPos.y && Mathf.Abs(transform.position.y - sandikPos.y) > 0.3f)
        {
            transform.position += new Vector3(0, Mathf.Abs(transform.position.y - sandikPos.y) / speedEks + speed, 0);
        }
    }
}
