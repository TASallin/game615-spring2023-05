using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletDrop : MonoBehaviour {
    public Rigidbody pallet;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            pallet.useGravity = true;
            pallet.isKinematic = false;
        }
    }
}
