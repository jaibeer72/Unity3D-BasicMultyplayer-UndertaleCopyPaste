using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RocketUP : NetworkBehaviour{

    private float speed = 5;
    private int damage = 5;
    private float lifetime = 5f;
    float age;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    [ServerCallback]
	void Update () {
        age += Time.deltaTime;
        if(age > lifetime){
            NetworkServer.Destroy(gameObject);
        }
        this.transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
    //[ServerCallback]
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        other.gameObject.GetComponent<HeartMoveMent>().takeDameage(damage);
    //    }

    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isServer)
        {
            return;
        }
        if (collision.gameObject.tag == "Player")
        {
            //Lol wht 
            collision.gameObject.GetComponentInParent<TheRoutiene>().takeDameage(damage);
        }
    }

}
