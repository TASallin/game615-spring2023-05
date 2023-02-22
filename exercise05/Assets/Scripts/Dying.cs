using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    float countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
            transform.Rotate(new Vector3(0, 0, 40 * Time.deltaTime));
        }
    }
}
