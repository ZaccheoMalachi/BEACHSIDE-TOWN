using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class rock : MonoBehaviour
{
    inventorysystem inventory;
    TextMeshProUGUI rocktext;

    // Start is called before the first frame update
    void Start()
    {
        rocktext = GameObject.Find("rockst").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inventory = other.GetComponent<inventorysystem>();
        if (other.gameObject.CompareTag("Player"))
        {
            inventory.collectrock(Random.Range(1, 3));
            rocktext.text = inventory.nrock.ToString();
            Destroy(gameObject);
        }
    }
}
