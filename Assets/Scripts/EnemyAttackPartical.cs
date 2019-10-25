using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class EnemyAttackPartical : NetworkBehaviour
{
    //public HeartMoveMent player;
    public ParticleSystem ps;
    public int Damage = 5;
    public GameObject Player;
    private float lifetime = 5f;
    float age;
    // Use this for initialization
    private void Start()
    {
       // ps.transform.position = spwanPos.transform.position;
        ps.Play();
        Debug.Log("Is playing partical");
    }


    [ServerCallback]
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition)
        age += Time.deltaTime;
        if (age > lifetime)
        {
            NetworkServer.Destroy(gameObject);
        }

    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!isServer)
            {
                return;
            }
            Debug.Log("HIT");
            other.GetComponentInParent<TheRoutiene>().takeDameage(Damage);
        }
    }
    //private void OnParticleTrigger()
    //{
    //    ParticleSystem ps = GetComponent<ParticleSystem>();

    //    List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
    //    //List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

    //    int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    //    //int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    //    for (int i = 0; i < numEnter; i++)
    //    {
    //        Debug.Log("Hit");
    //        Player.GetComponent<HeartMoveMent>().takeDameage(Damage);
    //    }
    //    // set
    //    ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
    //    //ps.SetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    //}
}
