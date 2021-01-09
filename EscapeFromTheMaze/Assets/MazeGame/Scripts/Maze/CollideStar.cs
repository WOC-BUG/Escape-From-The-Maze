using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideStar : MonoBehaviour
{
    public GameObject parameter;
    void Start()
    {
        //DontDestroyOnLoad(parameter);
    }
    void OnTriggerEnter(Collider other)
    {
        PassParameter.number++;  //获取物品数目+1
        PassParameter.star = true;    // 标记获得星星
        Debug.Log("是否获取到星星："+ PassParameter.star);
        Debug.Log("是否获取到礼物："+ PassParameter.present);
        Debug.Log("是否获取到雪花："+ PassParameter.snow);

        //加载场景，但不销毁原场景
        //LoadSceneMode有两种：Single表示关闭原场景，Additive表示将场景添加到当前加载的场景中
        //SceneManager.LoadSceneAsync("Vuforia", LoadSceneMode.Single);

        Destroy(GameObject.Find("7-Tip-Star"));     //碰撞后就销毁物体
        SceneManager.LoadScene("Vuforia");
        //Application.LoadLevelAdditive("Vuforia");
    }
}
