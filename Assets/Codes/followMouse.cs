using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    private Vector3 focusPos;
    private Vector3 mousePos;
    private Vector3 offset = new Vector3(0,0,-5f);
    public Transform player;
    public float treshold = 1;
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        focusPos = player.position + mousePos;

        focusPos.x = Mathf.Clamp(focusPos.x, -treshold + player.position.x, treshold + player.position.x);
        focusPos.y= Mathf.Clamp(focusPos.y, -treshold + player.position.y, treshold + player.position.y);
        focusPos.z = offset.z;
        this.transform.position = focusPos;
        
    }
}
