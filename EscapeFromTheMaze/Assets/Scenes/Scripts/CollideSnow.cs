using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideSnow : MonoBehaviour
{
    public GameObject parameter;
    void Start()
    {
        GameObject.DontDestroyOnLoad(parameter);
    }
    void OnTriggerEnter(Collider other)
    {
        parameter.GetComponent<PassParameter>().number++;  //获取物品数目+1
        parameter.GetComponent<PassParameter>().snow = true;    // 标记获得雪花
        Debug.Log("是否获取到星星：" + parameter.GetComponent<PassParameter>().star);
        Debug.Log("是否获取到礼物：" + parameter.GetComponent<PassParameter>().present);
        Debug.Log("是否获取到雪花：" + parameter.GetComponent<PassParameter>().snow);
        //加载场景，但不销毁原场景
        //LoadSceneMode有两种：Single表示关闭原场景，Additive表示将场景添加到当前加载的场景中
        SceneManager.LoadSceneAsync("Vuforia", LoadSceneMode.Single);
    }
}
