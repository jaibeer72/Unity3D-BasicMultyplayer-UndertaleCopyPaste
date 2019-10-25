using System;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


//[System.Serializable]
//public struct PrefabSaveStruct
//{
//    public int number;
//    public GameObject AttackTypesPREFAB;
//    public typeOFAtt TypeOfAttack;
//};

//[System.Serializable]
//public struct PrefabManager
//{
//    public typeOFAtt type;
//    public GameObject Prefab; 
//};


//public class GameCTRL : MonoBehaviour {
//    public static GameCTRL ctrl;
//    public PrefabSaveStruct[] PM;
//    public PrefabManager[] PrefabM;
//    public GameObject Heart; 
//    public int count = 0;
//    // Use this for initialization
//    void Awake() {
//        if (ctrl == null)
//        {
//            DontDestroyOnLoad(gameObject);
//            ctrl = this;
//        }
//        else if (ctrl != null)
//        {
//            Destroy(gameObject);
//        }
//	}

//    //private void OnGUI()
//    //{
//    //    for (int i = 0; i < PM.Length; i++)
//    //    {
//    //        GUI.Label(new Rect(10, 10+(i*3), 100, 100), "PrefabPos" + PM[i].AttackTypesPREFAB);
//    //    }
//    //    if(GUI.Button(new Rect(10, 100, 100, 30), "Basic"))
//    //    {
//    //        if (count == 0)
//    //        {
//    //            Delete();// to delete a file during initial commit
//    //        }
//    //        PM[count].AttackTypesPREFAB = PrefabM[0].Prefab;
//    //        PM[count].TypeOfAttack = typeOFAtt.basic;
//    //        //InstantiatteCurrent();
//    //    }
//    //    if (GUI.Button(new Rect(10, 120, 100, 30), "TimeDelay"))
//    //    {
//    //        if (count == 2)
//    //        {
//    //            Delete();// to delete a file during initial commit
//    //        }
//    //        PM[count].AttackTypesPREFAB = PrefabM[1].Prefab;
//    //        PM[count].TypeOfAttack = typeOFAtt.timeDelay;
//    //        //InstantiatteCurrent();
//    //    }
//    //    if (GUI.Button(new Rect(10,160, 100, 30), "Save"))
//    //    {
//    //        Save();
//    //    }
//    //    if (GUI.Button(new Rect(10, 200, 100, 30), "load"))
//    //    {
//    //        Load(); 
//    //    }
//    //    if (GUI.Button(new Rect(10, 250, 100, 30), "left"))
//    //    {
//    //        Heart.transform.Translate(Vector3.left * Time.deltaTime * 5);
//    //        //InstantiatteCurrent();
//    //    }
//    //    if (GUI.Button(new Rect(50, 300, 100, 30), "right"))
//    //    {
//    //        Heart.transform.Translate(Vector3.right * Time.deltaTime * 5);
//    //        //InstantiatteCurrent();
//    //    }
//    //    if (GUI.Button(new Rect(100, 350, 100, 30), "lUp"))
//    //    {
//    //        Heart.transform.Translate(Vector3.up * Time.deltaTime * 5);
//    //        //InstantiatteCurrent();
//    //    }
//    //    if (GUI.Button(new Rect(150, 400, 100, 30), "Down"))
//    //    {
//    //        Heart.transform.Translate(Vector3.down * Time.deltaTime * 5);
//    //        //InstantiatteCurrent();
//    //    }             

//    //   if((GUI.Button(new Rect(200, 450, 100, 30), "GoToLobby")))
//    //    {
//    //            SceneManager.LoadScene("NetworkLobby", LoadSceneMode.Additive);
//    //    }

//    //}

//    public void Place()
//    {
//        PM[count].AttackTypesPREFAB.transform.position = Heart.transform.position;
//        Debug.Log(PM[count].AttackTypesPREFAB.transform.position);
//        count++;
//    }
//    public void Save()
//    {
//        BinaryFormatter BF = new BinaryFormatter();
//        PM[count].AttackTypesPREFAB.transform.position = Heart.transform.position;
//        Debug.Log(PM[count].AttackTypesPREFAB.transform.position.x);
//        FileStream file;
//        if (File.Exists(Application.persistentDataPath + "/Placement.dat"))
//        {
//            file = File.Open(Application.persistentDataPath + "/Placement.dat", FileMode.Append); 
//        }
//        else
//        {
//            file = File.Create(Application.persistentDataPath + "/Placement.dat"); 
//        }    
//        PlacementData data = new PlacementData();
//        //seeing info 

//        data.number =PM[count].number;
//        data.posX = PM[count].AttackTypesPREFAB.transform.position.x;
//        data.posY = PM[count].AttackTypesPREFAB.transform.position.y;
//        data.TypeOfAttack = PM[count].TypeOfAttack;
//        BF.Serialize(file, data);
//        count++;
//        file.Close(); 
//    }
//    public void Load()
//    {

//        if(File.Exists(Application.persistentDataPath + "/Placement.dat"))
//        {
//            BinaryFormatter BF = new BinaryFormatter();
//            FileStream file = File.Open(Application.persistentDataPath + "/Placement.dat",FileMode.Open);
//            int count = 0;
//            while (file.CanRead)
//            {
//                PlacementData data = (PlacementData)BF.Deserialize(file);
//                //file.Close();
//                PM[count].number = data.number;
//                PM[count].AttackTypesPREFAB.transform.position = new Vector3(data.posX, data.posY, 0);
//                PM[count].TypeOfAttack = data.TypeOfAttack;

//                Debug.Log("Count:=" + count);
//                Debug.Log(PM[count].AttackTypesPREFAB.transform.position.x);
//                count++;
//            }
//            file.Close();
//        }

//    }
//    public void Delete()
//    {
//        if (File.Exists(Application.persistentDataPath + "/Placement.dat"))
//        {
//            File.Delete(Application.persistentDataPath + "/Placement.dat");
//        }
//        else Debug.Log("ERROR FILE DOES NOT EXIST");
//    }
//    //TODO instantiate gameobject. 

//    public void SetPrefab(typeOFAtt type)
//    {
//        switch (type)
//        {
//            case typeOFAtt.basic:
//                break;
//            case typeOFAtt.timeDelay:
//                break; 
//            default:
//                break;
//        }
//    }
//}

//public enum typeOFAtt
//{
//    basic,
//    timeDelay
//};


//[Serializable]
//class PlacementData
//{
//    public int number;
//    public float posX, posY; 
//    public typeOFAtt TypeOfAttack;
//}