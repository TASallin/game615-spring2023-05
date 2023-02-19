using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveTrigger : MonoBehaviour
{
    public Vector3 target;
    public SurvivorSteve steve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            steve.targetPosition = target;
        }
    }
}
