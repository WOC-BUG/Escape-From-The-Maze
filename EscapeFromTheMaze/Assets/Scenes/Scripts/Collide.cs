using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
    public GameObject gameObject;
    private GameObject star= GameObject.Find("7-Tip-Star");
    private GameObject present= GameObject.Find("Present-01");
    private GameObject snow= GameObject.Find("Snowflake");
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<PassParameter>().number++;  //获取物品数目+1
        if (this == star)
            gameObject.GetComponent<PassParameter>().star = true;
        if (this == present)
            gameObject.GetComponent<PassParameter>().present = true;
        if (this == snow)
            gameObject.GetComponent<PassParameter>().snow = true;
        Debug.Log("当前物品数量为："+gameObject.GetComponent<PassParameter>().number);
        Debug.Log("是否获取到星星："+gameObject.GetComponent<PassParameter>().star);
        Debug.Log("是否获取到礼物："+gameObject.GetComponent<PassParameter>().present);
        Debug.Log("是否获取到雪花："+gameObject.GetComponent<PassParameter>().snow);
        //加载场景，但不销毁原场景
        //LoadSceneMode有两种：Single表示关闭原场景，Additive表示将场景添加到当前加载的场景中
        SceneManager.LoadSceneAsync("Vuforia", LoadSceneMode.Single); 
    }
}
