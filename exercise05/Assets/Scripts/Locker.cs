using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public PlayerStun stun;
    public AudioSource voice;
    public Uroburos uroburos;
    public GameObject flashbang;
    public bool explode;

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
            stun.StunPlayer(2);
            uroburos.gameObject.SetActive(true);
            Destroy(gameObject, 1);
            GetComponent<Collider>().enabled = false;
            if (voice != null) {
                voice.Play();
            }
            
        }
    }

    void OnDestroy() {
        if (explode) {
            flashbang.SetActive(true);
        }
    }
}
