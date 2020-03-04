using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // X____  _X___  __X__  ___X_  ____X    Cylinder            Modeled

        // XX___  _XX__  __XX_  ___XX           Block stack

        // X_X__  _X_X_  __X_X                  Gate

        // __X__  __X__
        // _X___  ___X_
        // X____  ____X

        // XX_XX                                Pipes
        // XX_XX
        // XX_XX
        // XX_XX
        // XX_XX

        // XX_XX                                -----
        // XX_XX
        // XX__X
        // XX__X
        // X___X
        // X___X
        // X____
        // X____

        // XXXX_  _XXXX                         Laser

        // _X_X_                                Connected cylinders
        // _____
        // _X_X_

        // X____  _X___  __X__  ___X_  ____X    Pipe
        // X____  _X___  __X__  ___X_  ____X
        // X____  _X___  __X__  ___X_  ____X
        // X____  _X___  __X__  ___X_  ____X
        // X____  _X___  __X__  ___X_  ____X
        // X____  _X___  __X__  ___X_  ____X

        // XX_XX                                Beacon
        // X___X
        // _____
        // __X__
        // _XXX_
        // __X__
        // _____
        // X___X
        // XX_XX
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
