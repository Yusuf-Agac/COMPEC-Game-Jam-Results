using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidB;
    private Vector3 moveDir;
    private Camera cam;
    private Vector2 camPos;

    public float mapX = 7f;
    public float mapY = 5f;

    private float moveX;
    private float moveY;
    public float Speed = 10f;

    // Start is called before the first frame update
    void Awake()
    {
        rigidB = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        moveDir = new Vector3(moveX, moveY);

        camPos=cam.WorldToScreenPoint(Input.mousePosition);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -mapX, mapX), Mathf.Clamp(transform.position.y, -mapY, mapY));
    }


    private void FixedUpdate()
    {
        rigidB.velocity = moveDir * Speed * Time.deltaTime;
    }
}
