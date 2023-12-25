using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERASWITCH : MonoBehaviour
{
    public Camera main;
    public Camera wide;
    public Camera mid;
    public Camera close;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            main.enabled = true;
            wide.enabled = false;
            mid.enabled = false;
            close.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            main.enabled = false;
            wide.enabled = true;
            mid.enabled = false;
            close.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            main.enabled = false;
            wide.enabled = false;
            mid.enabled = true;
            close.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            main.enabled = false;
            wide.enabled = false;
            mid.enabled = false;
            close.enabled = true;
        }
    }
}
