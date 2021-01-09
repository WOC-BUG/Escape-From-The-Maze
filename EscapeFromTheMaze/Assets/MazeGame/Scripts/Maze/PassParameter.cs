using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// 该对象用于在场景中传递参数
public class PassParameter : MonoBehaviour
{
    static public int number = 0;   //获取物品数量

    //标记当前已获取的是哪个物品
    static public bool star = false;
    static public bool present = false;
    static public bool snow = false;

    static public float time = 0;  //计时
    static public bool finishGame = false;    //是否正常通关


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; //计时
        //Debug.Log(time);
    }
}
