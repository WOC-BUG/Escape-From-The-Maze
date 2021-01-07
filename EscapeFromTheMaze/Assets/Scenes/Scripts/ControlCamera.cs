using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform SphereTransform;   //小球当前位置
    private Vector3 distance;           //摄像机于小球之间的距离

    // Use this for initialization
    void Start()
    {
        distance = transform.position - SphereTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //主摄像机的位置=每次小球移动的位置+之间的距离
        transform.position = SphereTransform.position + distance;

        //手指触摸/电脑左键点击
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {
            // 获得鼠标当前位置的X和Y
            float mouseX = Input.GetAxis("Mouse X") * moveSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * moveSpeed;

            // 鼠标在Y轴上的移动号转为摄像机的上下运动，即是绕着X轴反向旋转
            Camera.main.transform.localRotation = Camera.main.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
            // 鼠标在X轴上的移动转为主角左右的移动，同时带动其子物体摄像机的左右移动
            transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
        }

        //// 第三人称摄像机跟随旋转
        //transform.position = Vector3.Lerp(transform.position, SphereTransform.position + distance, Time.deltaTime * 5);
        //Quaternion rotation = Quaternion.LookRotation(SphereTransform.position - transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 3f);
    }
}