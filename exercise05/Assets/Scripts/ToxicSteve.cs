using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicSteve : MonoBehaviour
{
    public Transform player;
    float stunTimer;
    float blindTimer;
    public Vector3 target;
    public float speed;
    bool walking;
    public AudioSource goodMusic;
    public AudioSource funnyMusic;
    public AudioSource weskuh;

    // Start is called before the first frame update
    void Start()
    {
        stunTimer = 0.5f;
        blindTimer = 3f;
        walking = true;
    }

    void OnEnable() {
        goodMusic.Stop();
        funnyMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (stunTimer >= 0) {
            stunTimer -= Time.deltaTime;
            if (stunTimer <= 0) {
                player.Rotate(new Vector3(0, 180, 0));
                weskuh.Play();
            }
        }
        if (blindTimer >= 0) {
            blindTimer -= Time.deltaTime;
            if (blindTimer <= 0) {
                Destroy(gameObject);
            }
        }
        if (walking && Vector3.Distance(target, transform.position) > 0.05f) {
            transform.Translate(Vector3.Normalize(target - transform.position) * speed * Time.deltaTime, Space.World);
            if (Vector3.Distance(target, transform.position) <= 0.05f) {
                walking = false;
                transform.Rotate(new Vector3(0, 180, 0));
            }
        }
        if (!walking) {
            float yPos = target.y + 0.25f * Mathf.Sin(50 * Time.time);
            transform.position = new Vector3(target.x, yPos, target.z);
        }
    }
}
