using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{    
    private Rigidbody rb;   //刚体对象    
    public int speed = 5;   //小球移动速度

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //接收刚体组件
    }

    void Update()
    {
        //Input.GetAxis用于检测是否按下键盘按键
        float h = Input.GetAxis("Horizontal");  //Horizontal表示水平按键
        float v = Input.GetAxis("Vertical");    //Vertical表示垂直按键
        
        rb.AddForce(new Vector3(h, 0, v) * speed);  //添加一个力
    }
}