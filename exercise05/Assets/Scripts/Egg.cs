using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Egg : MonoBehaviour {
    float startZ;
    float startX;
    public float zRange;
    public float xRange;
    public float throwSpeed;
    public float moveSpeed;
    public int state;
    public GameObject splat;
    public FirstPersonController playerController;
    public Transform player;
    public AudioSource sfx;
    public GameObject ui;
    public Dying dying;
    // Start is called before the first frame update
    void Start() {
        state = 0;
        startZ = transform.position.z;
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update() {
        if (state == 0) {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * throwSpeed));
            if (transform.position.z > startZ + zRange) {
                state = 1;
            }
        } else if (state == 1) {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * throwSpeed));
            if (transform.position.z < startZ) {
                state = 2;
            }
        } else if (state == 2) {
            transform.Translate(new Vector3(Time.deltaTime * moveSpeed, 0, 0));
            if (transform.position.x > startX + xRange) {
                state = 3;
            }
        } else if (state == 3) {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * throwSpeed));
            if (transform.position.z > startZ + zRange) {
                state = 4;
            }
        } else if (state == 4) {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * throwSpeed));
            if (transform.position.z < startZ) {
                state = 5;
            }
        } else {
            transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
            if (transform.position.x < startX) {
                state = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            splat.SetActive(true);
            playerController.enabled = false;
            dying.enabled = true;
            sfx.Play();
            ui.SetActive(true);
            Destroy(gameObject);
        }
    }
}