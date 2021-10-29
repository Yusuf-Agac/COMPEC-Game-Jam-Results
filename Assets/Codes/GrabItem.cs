using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{
    public LayerMask items;
    public LayerMask sandiks;
    public Shooting shootingScript;
    public RandomPaperGenerator Gener;
    public RandomCatGenerator Gener2;
    private VoteAmount voteAm;
    public damaged damaged;
    private float oyCalmaKatsayisi = 0;
    // Start is called before the first frame update
    void Start()
    {
        Gener = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<RandomPaperGenerator>();
        Gener2 = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<RandomCatGenerator>();
        voteAm = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<VoteAmount>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Collider2D[] item = Physics2D.OverlapCircleAll(transform.position, 0.5f, items);
            Collider2D[] sandik = Physics2D.OverlapCircleAll(transform.position, 2f, sandiks);
            foreach (Collider2D items in item)
            {
                if (items.tag.Equals("Paper") && !shootingScript.isPaperInAmmo)
                {
                    shootingScript.isPaperInAmmo = true;
                    items.GetComponent<DestoyItem>().DestroyItems();
                    Gener.PaperCounter--;
                    break;
                }

                else if (items.tag.Equals("cat") && !shootingScript.isPaperInAmmo)
                {
                    shootingScript.isCatInAmmo = true;
                    items.GetComponent<DestoyItem>().DestroyItems();
                    Gener2.CatCounter--;
                    break;
                }
            }
            foreach (Collider2D sandiks in sandik)
            {
                if (damaged.oyCalabilirsin && sandiks.tag.Equals("sandik"))
                {
                    oyCalmaKatsayisi++;
                    if (oyCalmaKatsayisi>=2)
                    {
                        voteAm.myVote++;
                        oyCalmaKatsayisi = 0;
                    }
                }
            }
        }
    }
}
