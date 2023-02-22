using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisable : MonoBehaviour
{
    float countdown;
    public AudioSource pop;
    // Start is called before the first frame update
    void OnEnable()
    {
        countdown = 3;
        pop.Play();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0) {
            gameObject.SetActive(false);
        }
    }
}
