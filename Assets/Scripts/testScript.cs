using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public float startDeg, endDeg, speed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            gameObject.transform.Rotate(Vector3.up ,Time.deltaTime*speed);
        }
        else if (Input.GetButton("Vertical"))
        {
            gameObject.transform.Rotate(Vector3.up ,-Time.deltaTime*speed);
        }
    }
}