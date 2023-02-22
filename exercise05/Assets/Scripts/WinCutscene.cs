using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class WinCutscene : MonoBehaviour
{
    public Rigidbody steve;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public AudioSource weskuhVoice;
    public GameObject egg;
    public Transform player;
    public FirstPersonController playerController;
    public GameObject ui;

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
            playerController.enabled = false;
            player.position = playerPosition;
            player.rotation = Quaternion.Euler(playerRotation);
            steve.useGravity = true;
            steve.isKinematic = false;
            egg.SetActive(false);
            weskuhVoice.Play();
            ui.SetActive(true);
        }
    }
}
