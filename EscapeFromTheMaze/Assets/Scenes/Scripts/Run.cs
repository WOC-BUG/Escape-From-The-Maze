using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;
    //private Rigidbody rb;   //刚体对象    
    //public int speed = 5;   //小球移动速度

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); //接收刚体组件
    }

    void Update()
    {
        ////Input.GetAxis用于检测是否按下键盘按键
        //float h = Input.GetAxis("Horizontal");  //Horizontal表示水平按键
        //float v = Input.GetAxis("Vertical");    //Vertical表示垂直按键

        //rb.AddForce(new Vector3(h, 0, v) * speed);  //添加一个力
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0 || v != 0)
        {
            Vector3 targetDirection = new Vector3(h, 0, v);
            float y = Camera.main.transform.rotation.eulerAngles.y;
            targetDirection = Quaternion.Euler(0, y, 0) * targetDirection;

            transform.Translate(targetDirection * Time.deltaTime * moveSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }
}