using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponRotater : MonoBehaviour
{
    private Camera cam;
    private Vector3 Pos;
    private Transform startPosition;

    public float weaponsPosXOffset = 0.04f;
    public float weaponsPosYOffset = 0.05f;

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        startPosition = GameObject.FindGameObjectWithTag("0_Noktasi").GetComponent<Transform>();
        Pos = startPosition.position;

        var objectPos = Camera.main.WorldToScreenPoint(transform.position);
        var objectStartPos = Camera.main.WorldToScreenPoint(startPosition.position);
        
        var dir = Input.mousePosition - objectPos;
        var dir2 = Input.mousePosition - objectStartPos;

        if (Mathf.Atan2(dir2.x, -dir2.y) * Mathf.Rad2Deg > 0)
        {
            transform.position = new Vector3(Pos.x - weaponsPosXOffset, Pos.y - weaponsPosYOffset, Pos.z);

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(dir.x, -dir.y) * Mathf.Rad2Deg - 90f));
        }

        if(Mathf.Atan2(dir2.x, -dir2.y) * Mathf.Rad2Deg <= 0)
        {
            transform.position = new Vector3(Pos.x + weaponsPosXOffset, Pos.y - weaponsPosYOffset, Pos.z);

            transform.rotation = Quaternion.Euler(new Vector3(180, 0, Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg - 90f));
        }
        
    }
}
