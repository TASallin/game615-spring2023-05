using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public PlayerStun stun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player")) {
            stun.StunPlayer(1);
            Destroy(gameObject);
        }
    }
}
