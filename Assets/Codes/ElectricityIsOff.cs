using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityIsOff : MonoBehaviour
{
    public LayerMask trafo;
    public float radius = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region overLap
        Collider2D[] item = Physics2D.OverlapCircleAll(transform.position, radius, trafo);
        foreach (Collider2D items in item)
        {
            items.GetComponent<damaged>().damagedLook();
            Destroy(this.gameObject);
        }
        #endregion

    }
}
