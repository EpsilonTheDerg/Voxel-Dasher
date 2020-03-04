using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsTriggerStruck : MonoBehaviour
{
    // Random value that selects what obstacle to bring forth
    public static int obsValue;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 0)
        {
            obsValue = Random.Range(1, 4);
            if (obsValue == 1 || obsValue == 2)
            {
                transform.position = new Vector3(0, 0, 75);
            }
            if (obsValue == 3)
            {
                transform.position = new Vector3(0, 0, 75);
            }
            else
            {
                transform.position = new Vector3(0, 0, 50);
            }
        }
    }
}
