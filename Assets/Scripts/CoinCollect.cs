using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Logging the audio source
    public AudioSource coinSound;

    // Individual "collected" variable
    bool isCoinCollected = false;

    // Random positioning along the X axis
    float randMove;

    // Random Z position multiplier
    public float multiplier = 3;

    // Game speed for determining where the coin respawns
    float speed;

    public static int coinCount;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        randMove = Random.Range(4f, -4f);
        transform.position += new Vector3(randMove, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        speed = MovementSpeedUp.gameSpeed;
        if(transform.position.z < -20 || isCoinCollected)
        {
            transform.position += new Vector3((randMove * -1), 0, 0);
            randMove = Random.Range(4f, -4f);
            transform.position += new Vector3(randMove, 0f, (Random.Range(75 - (multiplier * speed), 75 + (multiplier * speed))) + speed);
            if(isCoinCollected)
            {
                isCoinCollected = false;
            }
        }
    }

    // When a coin hits the player
    void OnTriggerEnter(Collider other)
    {
        // Basically if the coin hit the player's hitbox
        if(other.CompareTag("Player"))
        {
            // Play the sound
            coinSound.Play();

            // Mark it as collected
            isCoinCollected = true;

            coinCount = coinCount + 1;
        }
    }

}
