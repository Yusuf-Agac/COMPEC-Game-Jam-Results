using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headRotater : MonoBehaviour
{
    private Camera cam;

    private Vector3 Pos;

    private Transform startPosition;

    public float headsPosXOffset = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        startPosition = GameObject.FindGameObjectWithTag("0_Noktasi").GetComponent<Transform>();
        Pos =  startPosition.position;

        var objectPos = Camera.main.WorldToScreenPoint(transform.position);
        var objectStartPos = Camera.main.WorldToScreenPoint(startPosition.position);

        var dir = Input.mousePosition - objectPos;
        var dir2 = Input.mousePosition - objectStartPos;

        //Right
        if (Mathf.Atan2(dir2.x, -dir2.y) * Mathf.Rad2Deg > 0)
        {
            transform.position = new Vector3(Pos.x - headsPosXOffset, Pos.y, Pos.z);

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

        //Left
        if (Mathf.Atan2(dir2.x, -dir2.y) * Mathf.Rad2Deg <= 0)
        {
            transform.position = new Vector3(Pos.x + headsPosXOffset, Pos.y, Pos.z);

            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
    }
}
