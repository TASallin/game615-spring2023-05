using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutscene : MonoBehaviour
{
    public AudioSource weskin;
    public AudioSource bgm;
    public AudioSource intro1;
    public AudioSource intro2;
    public AudioSource intro3;
    public AudioSource intro4;
    public AudioSource intro5;
    public AudioSource hangUp;
    public PlayerStun stun;
    public GameObject uroburos;
    float countdown;
    int state;
    public GameObject phone;

    // Start is called before the first frame update
    void Start()
    {
        intro1.Play();
        stun.StunPlayer(17);
        state = 0;
        countdown = 7;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0) {
            if (state == 0) {
                state = 1;
                countdown = 2;
                intro2.Play();
            } else if (state == 1) {
                state = 2;
                countdown = 4;
                intro3.Play();
            } else if (state == 2) {
                state = 3;
                countdown = 2;
                intro4.Play();
            } else if (state == 3) {
                state = 4;
                countdown = 1;
                intro5.Play();
                hangUp.Play();
            } else if (state == 4) {
                state = 5;
                countdown = 1;
                uroburos.SetActive(true);
            } else if (state == 5) {
                state = 6;
                countdown = 1;
                phone.SetActive(false);
            } else {
                weskin.Play();
                bgm.Play();
                Destroy(gameObject);
            }
        }
    }
}
