using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HeartColor : NetworkBehaviour{
    [SyncVar]
    public Color color;
    public SpriteRenderer mat; 
	// Use this for initialization
	void Start () {
        GameObject[] Heart = GameObject.FindGameObjectsWithTag("heart");
        if (Heart[0].GetComponent<HeartMoveMent>() != null)
        {
            //means Heart[0]is local player or else the script was destroyed 
            Heart[0].GetComponent<SpriteRenderer>().color = Color.yellow;
            Heart[1].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            Heart[1].GetComponent<SpriteRenderer>().color = Color.yellow;
            Heart[0].GetComponent<SpriteRenderer>().color = Color.red;
        } 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
