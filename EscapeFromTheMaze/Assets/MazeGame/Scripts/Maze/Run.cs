using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;
    private float h = 0;
    private float v = 0;

    //private Rigidbody rb;   //刚体对象

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>(); //接收刚体组件
    }

    void Update()
    {
        //首先检测有没有点击按钮，没有再选择键盘输入
        if (Mathf.Abs(GoForward.h) > 0 || Mathf.Abs(GoForward.v) > 0)
        {
            h = GoForward.h;
            v = GoForward.v;
        }
        else if (Mathf.Abs(GoBack.h) > 0 || Mathf.Abs(GoBack.v) > 0)
        {
            h = GoBack.h;
            v = GoBack.v;
        }
        else
        {
            //Input.GetAxis用于检测是否按下键盘按键
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }

        //rb.AddForce(new Vector3(h, 0, v) * moveSpeed);  //给刚体添加一个力

        //移动物体
        if (h != 0 || v != 0)
        {
            Vector3 targetDirection = new Vector3(h, 0, v);

            //将方向转换为相对于摄像机的方向
            float y = Camera.main.transform.rotation.eulerAngles.y;
            targetDirection = Quaternion.Euler(0, y, 0) * targetDirection;

            //更新位置
            transform.Translate(targetDirection * Time.deltaTime * moveSpeed, Space.World);
        }
    }
}