using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class HeartMoveMent : MonoBehaviour
{
    
    float ver, hor,mouseX,mouseY;
    public float speed;
    
    
    public GameObject hell;
    public float BarDistance = -2f;

    // Use this for initialization

    void Start () {
       
        
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        ver=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        hor=Input.GetAxis("Vertical")* Time.deltaTime*speed;
        transform.Translate(ver, hor, 0);
        //hell.transform.position = new Vector3(-this.transform.position.x, -this.transform.position.y, 0);
        //hell.transform.Translate(-ver, -hor, 0);

        //curPos = position;
        //if (curPos == lastPos)
        //{
        //    print("Not moving");
        //}
        //lastPos = curPos;
    }
}
