using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class PlayerStun : MonoBehaviour
{
    public FirstPersonController playerController;
    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        //countdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
            if (countdown <= 0) {
                playerController.enabled = true;
            }
        }
    }

    public void StunPlayer(float time) {
        playerController.enabled = false;
        countdown = time;
    }
}
