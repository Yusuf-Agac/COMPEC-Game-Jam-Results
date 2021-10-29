using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public LayerMask layerDayi;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }
    private void Update()
    {
        Collider2D[] bullet = Physics2D.OverlapCircleAll(transform.position, 0.3f, layerDayi);

        foreach(Collider2D bullets in bullet)
        {
            bullets.GetComponent<VoteHealth>().takeVoteDamage(1);
            Destroy(this.gameObject);
        }
    }
}
