using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnManager : NetworkBehaviour
{
    public GameObject[] lilyPadObjs = null;

    // Start is called before the first frame update
    public override void OnStartServer()
    {
        InvokeRepeating("SpawnLilyPad", 2.0f, 5.0f);
    }

    // Update is called once per frame
    void SpawnLilyPad()
    {
        foreach(GameObject lilyPad in lilyPadObjs)
        {
            GameObject templilyPad = Instantiate(lilyPad);
            NetworkServer.Spawn(templilyPad);
        }
    }
}
