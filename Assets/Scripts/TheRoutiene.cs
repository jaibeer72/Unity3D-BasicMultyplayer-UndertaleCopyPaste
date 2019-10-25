using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public enum typeOfAttacks { basic, LeftRocket };
//[System.Serializable]
//public struct PrefabSaveStruct
//{
//    typeOfAttacks TypeOf;
//    public GameObject Attack;
    
//};

public class TheRoutiene : NetworkBehaviour
{
    //private NetworkStartPosition[] spawnPoints;
    //private Transform BoxMidRef;
    public GameObject[] Attacks;
    public Text informationText; 
    public const float maxHealth = 20;
    public float currentHealth;
    public Slider healthBar;
    public Vector3 MousPos;
    public int count=0;
    public AudioClip win, loose, ambient;
    public AudioSource MainCamPlayer; 
    // Use this for initialization
    void Start()
    {
        MainCamPlayer = GetComponent<AudioSource>(); 
        currentHealth = maxHealth;
        healthBar.value = calculateHealth();
        if (isLocalPlayer) { MainCamPlayer.PlayOneShot(ambient); }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            //Destroy(this);
            //return;
            //}

            if (Input.GetKeyDown(KeyCode.Q))
            {
                count++;
                Debug.Log(count);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                count--;
                Debug.Log(count);
            }
            if (count > Attacks.Length || count < 0)
            {
                count = 1;
            }
            if (Input.GetMouseButtonDown(0))
            {
                MousPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
                Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition).x);
                CmdFire(count);
            }
        }
        
    }


    [Command]
    void CmdFire(int count)
    {
        
        Debug.Log("reaches Command");
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 Distance = BoxMidRef.position + All[i].transform.position;
        GameObject instance = Instantiate(Attacks[count],new Vector3(pos.x,pos.y,0) ,Quaternion.identity);
        Debug.Log(MousPos);
            instance.GetComponent<GameObject>();
            NetworkServer.Spawn(instance);
        


        //    bool ParticalCreated = false; 
        //    //GameCTRL.ctrl.Load();
        //    for (int i = 0; i < GameCTRL.ctrl.PM.Length; i++)
        //    {
        //        if (GameCTRL.ctrl.PM[i].TypeOfAttack == typeOFAtt.basic)
        //        {
        //            Debug.Log("typeof BASIC");
        //            if (ParticalCreated == false)
        //            {
        //                Vector3 temp = new Vector3(BoxMidRef.x + GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.position.x, BoxMidRef.y + GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.position.y,0);
        //                GameObject instance = Instantiate(GameCTRL.ctrl.PrefabM[0].Prefab,temp,GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.rotation);
        //                instance.GetComponent<ParticleSystem>().Play();
        //                NetworkServer.Spawn(instance);

        //                Debug.Log("reaches here insisde typeOfBasic");
        //            }
        //        }
        //        if(GameCTRL.ctrl.PM[i].TypeOfAttack == typeOFAtt.timeDelay)
        //        {
        //            Vector3 temp = new Vector3(BoxMidRef.x + GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.position.x, BoxMidRef.y + GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.position.y, 0);
        //            GameObject instance = Instantiate(GameCTRL.ctrl.PrefabM[0].Prefab, temp, GameCTRL.ctrl.PM[i].AttackTypesPREFAB.transform.rotation);
        //            instance.GetComponent<GameObject>();
        //            NetworkServer.Spawn(instance);
        //            Debug.Log("reaches here insisde Time Delay Created");
        //        }
        //    }
        //}
    }
    public void takeDameage(int amount)
    {
        if (!isServer)
        {
            return;
        }
        currentHealth -= amount;
        healthBar.value = calculateHealth();
        Debug.Log(currentHealth);
        if (currentHealth < 0)
        {
            currentHealth = 0;
            RpcDied();
            Invoke("BackToLobby", 15f);
            Debug.Log("Dead");
            return;
        }
    }
    float calculateHealth()
    {
        return currentHealth / maxHealth;
    }

    [ClientRpc]
    void RpcDied()
    {
        informationText = GameObject.FindObjectOfType<Text>();
        if (isLocalPlayer)
        {
            MainCamPlayer.Stop();
            MainCamPlayer.PlayOneShot(loose);
            informationText.text = "YOU LOOSE";
        }
        else
        {
            MainCamPlayer.Stop();
            MainCamPlayer.PlayOneShot(win);
            informationText.text = "You Win";
        }
    }
    void BackToLobby()
    {
        FindObjectOfType<NetworkLobbyManager>().ServerReturnToLobby();
    }
}