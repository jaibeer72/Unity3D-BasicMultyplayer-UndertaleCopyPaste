using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class IfNotLocal : NetworkBehaviour
{
   // private NetworkStartPosition[] spawnPoints;
    // Use this for initialization
    void Start () {
        //spawnPoints = FindObjectsOfType<NetworkStartPosition>();
        //Vector3 spawnPoint = Vector3.zero;
        if (!isLocalPlayer)
        {
            Destroy(this.gameObject.GetComponentInChildren<HeartMoveMent>());
        }
        if (isServer)
        {
            //spawnPoint = spawnPoints[0].transform.position;
            //transform.position = spawnPoint;
            Debug.Log("Runnsing as Host ");
        }
        else if(isClient)
        {
            //spawnPoint = spawnPoints[1].transform.position;
            //transform.position = spawnPoint;
            Debug.Log("Runnsing as Client ");
        }
    }
}
