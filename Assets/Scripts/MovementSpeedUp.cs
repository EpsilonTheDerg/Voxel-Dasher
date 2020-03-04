using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpeedUp : MonoBehaviour
{

    public static float gameSpeed = 0;
    public bool isGameRunning = false;
    public bool initialSpeedUp = false;
    public float initialSpeedLimit = 20;
    public float finalSpeedLimit = 100;
    public bool gameEnd;
    public int musicSelect;
    public AudioSource musHell;
    public AudioSource musHunt;
    public AudioSource musAstral;
    public AudioSource musCapn;
    public AudioSource musShock;
    public bool isMusicSelected;
    public AudioSource gameEndSound;
    public bool hasGameEnded;
    public float scoreFloat;
    public float scoreIncrease = 0.005f;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pull from ObstacleGameEnd
        gameEnd = ObstacleGameEnd.gameEnd;

        if(gameEnd && !hasGameEnded)
        {
            isGameRunning = false;
            isMusicSelected = false;
            musHell.Stop();
            musHunt.Stop();
            musAstral.Stop();
            musCapn.Stop();
            musShock.Stop();
            gameSpeed = 0;
            gameEndSound.Play();
            print("Game Over");
            hasGameEnded = true;
        }

        // Select and play music on game start
        if(isGameRunning && !isMusicSelected)
        {
            musicSelect = 0;
            musicSelect = Random.Range(1, 11);
            if(musicSelect > 5)
            {
                musicSelect = musicSelect - 5;
            }
            if(musicSelect == 1)
            {
                musHell.Play();
            }
            if(musicSelect == 2)
            {
                musHunt.Play();
            }
            if(musicSelect == 3)
            {
                musAstral.Play();
            }
            if(musicSelect == 4)
            {
                musCapn.Play();
            }
            if(musicSelect == 5)
            {
                musShock.Play();
            }
            isMusicSelected = true;
        }

        // Wait for button press, if so, then run
        if (isGameRunning && gameSpeed < finalSpeedLimit)
        {
            // Wait for the initial speed to run
            if (initialSpeedUp)
            {
                gameSpeed += (Time.deltaTime + 0.00005f);
            }
            else
            {
                gameSpeed += (Time.deltaTime + 0.05f);
            }
        }
        // Check if speed is over initialSpeedLimit
        if (gameSpeed >= initialSpeedLimit)
        {
            initialSpeedUp = true;
        }
        if(isGameRunning)
        {
            scoreFloat = scoreFloat + scoreIncrease;
            score = Mathf.RoundToInt(scoreFloat);
        }
    }
}
