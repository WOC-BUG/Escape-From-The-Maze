﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private GameObject passObject;
    //private GameObject score;
    private string oldTime;
    //private static bool isExist = false;    //是否已经存在DontDestroy的物体

    void Awake()
    {
        //score = GameObject.Find("TimeScore");
        //DontDestroyOnLoad(score);
        //if (!isExist)
        //{
        //    //如果第一次加载，将这些物体设为DontDestroy
        //    DontDestroyOnLoad(score);
        //    isExist = true;
        //}
        //else
        //{
        //    //如果已经存在，则删除重复的物体
        //    Destroy(score);
        //}
    }
    // Start is called before the first frame update
    void Start()
    {
        oldTime = GameObject.Find("TimeScore").GetComponent<Text>().text;
        passObject = GameObject.Find("Parameter");

        //关闭Maze场景音效
        passObject.GetComponent<AudioSource>().mute = true;

        Debug.Log("finishGame：" + PassParameter.finishGame);

        //如果游戏成功完成，且时间为-1，或者游戏用时更短了就更新记录
        if (PassParameter.finishGame == true &&
            (oldTime == "-1" || float.Parse(oldTime) > PassParameter.time))
        {
            PassParameter.finishGame = false;
            GameObject.Find("TimeScore").GetComponent<Text>().text = PassParameter.time.ToString();  //时间赋值
        }
        GameObject.Find("ObjectNumber").GetComponent<Text>().text = PassParameter.number.ToString();    //获取物品赋值
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Quit()
    {
        Application.Quit(); //退出游戏
    }

    public void ChangeScene()
    {
        if (passObject) //如果存在迷宫，即当前要重新开始游戏，就要把之前DontDestroyOnLoad的迷宫状态删了
        {
            Destroy(passObject);
        }
        SceneManager.LoadScene("Maze"); //加载一个新的迷宫场景
    }
}
