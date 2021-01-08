using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGame : MonoBehaviour
{
    private GameObject passObject;
    //private static bool isExist = false;    //是否已经存在DontDestroy的物体
    void Awake()
    {
        passObject = GameObject.Find("Parameter");
        DontDestroyOnLoad(passObject);
        //if (!isExist)
        //{
        //    //如果第一次加载，将这些物体设为DontDestroy
        //    DontDestroyOnLoad(passObject);
        //    isExist = true;
        //}
        //else
        //{
        //    //如果已经存在，则删除重复的物体
        //    Destroy(passObject);
        //}
    }
    public void Quit()
    {
        Application.Quit(); //退出游戏
    }

    public void Restart()
    {
        SceneManager.LoadScene("Index"); //重新加载场景
    }
}
