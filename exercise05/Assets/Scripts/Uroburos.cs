using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uroburos : MonoBehaviour
{
    public Vector3 startPos;
    float countdown;

    void Start() {
        startPos = transform.localPosition;
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        countdown = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown > 1) {
            transform.localPosition = startPos + new Vector3(0, 2 - countdown, 0);
        } else if (countdown > 0) {
            transform.localPosition = startPos + new Vector3(0, 1 - 10 * (1 - countdown), 0);
        } else {
            transform.localPosition = startPos;
            gameObject.SetActive(false);
        }
    }
}
