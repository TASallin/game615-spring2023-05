using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCollector : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI display;
    public AudioSource voice2;
    public AudioSource voice5;
    public AudioSource voice7;
    public AudioSource voice0;
    public GameObject particles;
    public Vector3 particleOffset;
    //public AudioSource sfx;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        //voice0.Play();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "$" + number;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectible")) {
            //other.gameObject.SetActive(false);
            GameObject part = Instantiate(particles, other.transform.position + particleOffset, Quaternion.identity);
            Destroy(part, 2);
            Destroy(other.gameObject);
            number += 1;
            if (number == 2) {
                voice2.Play();
            } else if (number == 5) {
                voice5.Play();
            } else if (number == 7) {
                voice7.Play();
            }
            //sfx.Play();
        }
    }
}
