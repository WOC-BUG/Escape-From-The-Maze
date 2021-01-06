using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Transform SphereTransform;   //设置一个距离的三维变量，用于保存摄像机于小球之间的距离
    private Vector3 distance;

    // Use this for initialization
    void Start()
    {
        //transform.position为主摄像机的位置
        //SphereTransform.position为小球的位置
        distance = transform.position - SphereTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //主摄像机的位置为每次小球移动的位置+之间的距离
        transform.position = SphereTransform.position + distance;
    }
}
