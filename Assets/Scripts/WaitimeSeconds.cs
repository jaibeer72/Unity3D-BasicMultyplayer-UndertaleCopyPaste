using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WaitimeSeconds : NetworkBehaviour{

    // Use this for initialization
    
    void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        StartCoroutine(Example());
    }

    [ServerCallback]
    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        print(Time.time);
    }
}
