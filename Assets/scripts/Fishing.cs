using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fishing : MonoBehaviour,Iinteractable
{
    inventorysystem inventory;
    TextMeshProUGUI fishstext;
    // Start is called before the first frame update
    void Start()
    {
        fishstext = GameObject.Find("fishst").GetComponent<TextMeshProUGUI>();
        inventory = GameObject.Find("PlayerArmature").GetComponent<inventorysystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void interact()
    {
        int nfish = Random.Range(0, 4);
        Debug.Log("Got "+nfish+" fish");
        inventory.collectfish(nfish);
        fishstext.text = inventory.nfish.ToString();
    }
}
