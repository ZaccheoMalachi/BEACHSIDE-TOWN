using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Iinteractable
{
    public void interact();
}

public class Interact : MonoBehaviour
{
    public Transform interactsource;
    public float interactrange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Ray r = new Ray(interactsource.position,interactsource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactrange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out Iinteractable interactobject)) 
                {
                    interactobject.interact();
                }
            }
        }
    }
}
