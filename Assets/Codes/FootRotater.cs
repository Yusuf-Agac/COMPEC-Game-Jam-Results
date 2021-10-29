using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootRotater : MonoBehaviour
{

    private bool rotateRight=false;
    private bool rotateLeft = false;


    // Update is called once per frame
    void Update()
    {

        //Right
        if (Input.GetAxis("Horizontal") > 0)
        {
            rotateRight = true;
        }

        //Left180
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rotateLeft = true;
        }

        if (rotateRight)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rotateRight = false;
        }

        else if (rotateLeft)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            rotateLeft = false;
        }
    }
}
