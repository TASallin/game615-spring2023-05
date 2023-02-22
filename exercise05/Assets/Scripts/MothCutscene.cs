using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothCutscene : MonoBehaviour {
    public PlayerStun stun;
    public MoneyCollector money;
    public GameObject steve;
    public GameObject pizzaBox;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public Transform player;
    float boxTimer;
    float steveTimer;
    public AudioSource buy;
    public AudioSource moth;

    // Start is called before the first frame update
    void Start() {
        boxTimer = 0;
        steveTimer = 0;
    }

    // Update is called once per frame
    void Update() {
        if (steveTimer > 0) {
            steveTimer -= Time.deltaTime;
            if (steveTimer <= 0) {
                steve.SetActive(true);
                Destroy(gameObject);
            }
        }
        if (boxTimer > 0) {
            boxTimer -= Time.deltaTime;
            if (boxTimer <= 0) {
                steveTimer = 1f;
                moth.Play();
                pizzaBox.SetActive(true);
                money.number = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && money.number >= 7) {
            stun.StunPlayer(10);
            player.position = playerPosition;
            player.rotation = Quaternion.Euler(playerRotation);
            boxTimer = 5f;
            buy.Play();
        }
    }
}
