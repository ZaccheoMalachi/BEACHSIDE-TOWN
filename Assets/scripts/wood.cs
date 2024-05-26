using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class wood : MonoBehaviour
{
    inventorysystem inventory;
    TextMeshProUGUI woodtext;

    // Start is called before the first frame update
    void Start()
    {
        woodtext = GameObject.Find("woodst").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inventory=other.GetComponent<inventorysystem>();
        if (other.gameObject.CompareTag("Player"))
        {
            inventory.collectwood(Random.Range(1, 3));
            woodtext.text = inventory.nwood.ToString();
            Destroy(gameObject);
        }
    }
}
