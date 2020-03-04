using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallObs_Cubes : MonoBehaviour
{
    Vector3 pos;
    public int aisle;
    public int obsValue;
    public bool inUse;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = MovementSpeedUp.gameSpeed;

        obsValue = ObsTriggerStruck.obsValue;
        if (obsValue == 3 && !inUse)
        {
            aisle = Random.Range(1, 5);
            transform.position = new Vector3((2 * aisle) - 5.5f, 0, 150);
            inUse = true;
        }
        if (transform.position.z < -10 && inUse)
        {
            inUse = false;
            transform.position = new Vector3((2 * aisle * -1) + 5.5f, 0, -10);
        }
    }
}
