using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//public class adjustScript : MonoBehaviour {

//    //float speed = 5;
//    //public int count = 0;
//    //PreaFabsManager PFM;
//    // Use this for initialization
//    //private void OnGUI()
//    //{
//    //    if(GUI.Button(new Rect(10, 100, 100, 30), "Basic"))
//    //    {
//    //        PFM.SetPrefab(typeOFAtt.basic);
//    //        //GameCTRL.ctrl.InstantiatteCurrent();

//    //    }
//    //    if (GUI.Button(new Rect(10, 120, 100, 30), "left"))
//    //    {
//    //        GameCTRL.ctrl.PM[GameCTRL.ctrl.count].AttackTypesPREFAB.transform.Translate(Vector3.left * speed * Time.deltaTime);
//    //    }
//    //}
//    private void OnGUI()
//    {
//        for (int i = 0; i < GameCTRL.ctrl.PM.Length; i++)
//        {
//            GUI.Label(new Rect(10, 10 + (i * 3), 100, 100), "PrefabPos" + GameCTRL.ctrl.PM[i].AttackTypesPREFAB);
//        }
//        if (GUI.Button(new Rect(10, 100, 100, 30), "Basic"))
//        {
            
//            GameCTRL.ctrl.PM[GameCTRL.ctrl.count].AttackTypesPREFAB = GameCTRL.ctrl.PrefabM[0].Prefab;
//            GameCTRL.ctrl.PM[GameCTRL.ctrl.count].TypeOfAttack = typeOFAtt.basic;
//            //InstantiatteCurrent();
//        }
//        if (GUI.Button(new Rect(10, 120, 100, 30), "TimeDelay"))
//        {
           
//            GameCTRL.ctrl.PM[GameCTRL.ctrl.count].AttackTypesPREFAB = GameCTRL.ctrl.PrefabM[1].Prefab;
//            GameCTRL.ctrl.PM[GameCTRL.ctrl.count].TypeOfAttack = typeOFAtt.timeDelay;
//            //InstantiatteCurrent();
//        }
//        if (GUI.Button(new Rect(10, 160, 100, 30), "Place"))
//        {
//            GameCTRL.ctrl.Place();
//        }
//        if (GUI.Button(new Rect(10, 200, 100, 30), "load"))
//        {
//            GameCTRL.ctrl.Load();
//        }
//        if (GUI.Button(new Rect(10, 250, 100, 30), "left"))
//        {
//            GameCTRL.ctrl.Heart.transform.Translate(Vector3.left * Time.deltaTime * 5);
//            //InstantiatteCurrent();
//        }
//        if (GUI.Button(new Rect(50, 300, 100, 30), "right"))
//        {
//            GameCTRL.ctrl.Heart.transform.Translate(Vector3.right * Time.deltaTime * 5);
//            //InstantiatteCurrent();
//        }
//        if (GUI.Button(new Rect(100, 350, 100, 30), "lUp"))
//        {
//            GameCTRL.ctrl.Heart.transform.Translate(Vector3.up * Time.deltaTime * 5);
//            //InstantiatteCurrent();
//        }
//        if (GUI.Button(new Rect(150, 400, 100, 30), "Down"))
//        {
//            GameCTRL.ctrl.Heart.transform.Translate(Vector3.down * Time.deltaTime * 5);
//            //InstantiatteCurrent();
//        }

//        if ((GUI.Button(new Rect(200, 450, 100, 30), "GoToLobby")))
//        {
//            SceneManager.LoadScene("NetworkLobby", LoadSceneMode.Additive);
//        }

//    }
//}
