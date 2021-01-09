using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollidePresent : MonoBehaviour
{
    public GameObject parameter;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        PassParameter.number++;  //获取物品数目+1
        PassParameter.present = true;    // 标记获得礼物
        Debug.Log("是否获取到星星：" + PassParameter.star);
        Debug.Log("是否获取到礼物：" + PassParameter.present);
        Debug.Log("是否获取到雪花：" + PassParameter.snow);

        // 设置按钮未按下
        GoForward.isDown = false;
        GoBack.isDown = false;

        Destroy(GameObject.Find("Present-01"));     //碰撞后就销毁物体
        SceneManager.LoadScene("Vuforia");
        //SceneManager.LoadSceneAsync("Vuforia", LoadSceneMode.Additive);
    }
}
