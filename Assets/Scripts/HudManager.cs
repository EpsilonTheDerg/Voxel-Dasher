using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    public Text score;
    public Text coins;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetHud();
    }

    // Update is called once per frame
    void Update()
    {
        ResetHud();
    }

    public void ResetHud()
    {
        score.text = "" + MovementSpeedUp.score;
        coins.text = "" + CoinCollect.coinCount;
    }
}
