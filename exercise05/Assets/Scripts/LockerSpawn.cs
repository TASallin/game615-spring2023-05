using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerSpawn : MonoBehaviour
{
    public GameObject locker;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            locker.SetActive(true);
        }
    }
}
