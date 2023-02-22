using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCutscene : MonoBehaviour
{
    public PlayerStun stun;
    public GameObject steve;
    public GameObject egg;
    public Transform player;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public AudioSource weskuhVoice;
    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
            if (countdown <= 0) {
                egg.SetActive(true);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            stun.StunPlayer(5);
            player.position = playerPosition;
            player.rotation = Quaternion.Euler(playerRotation);
            countdown = 5f;
            weskuhVoice.Play();
        }
    }
}
