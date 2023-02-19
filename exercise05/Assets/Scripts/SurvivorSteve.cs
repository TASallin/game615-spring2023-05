using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorSteve : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(targetPosition, transform.position) > 0.05f) {
            transform.Translate(Vector3.Normalize(targetPosition - transform.position) * speed * Time.deltaTime);
        }
    }
}
