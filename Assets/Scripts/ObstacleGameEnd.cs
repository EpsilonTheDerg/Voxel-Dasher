using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGameEnd : MonoBehaviour
{
    // Will determine if a game over should occur
    public static bool gameEnd;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameEnd = true;
        }
    }
}
