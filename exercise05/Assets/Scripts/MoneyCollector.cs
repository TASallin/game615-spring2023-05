using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCollector : MonoBehaviour
{
    int number;
    public TextMeshProUGUI display;
    //public AudioSource sfx;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "$" + number;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectible")) {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            number += 1;
            //sfx.Play();
        }
    }
}
