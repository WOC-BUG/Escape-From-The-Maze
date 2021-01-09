using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GoBack : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //h和v的值传回给player脚本，使得物体移动
    public static float h;
    public static float v;
    public static bool isDown = false;    //按钮是否被按下

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            h = 0;
            v = -1;
        }
        else
        {
            h = 0;
            v = 0;
        }
    }

    //长按按钮
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }

    //抬起下按钮
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }
}
