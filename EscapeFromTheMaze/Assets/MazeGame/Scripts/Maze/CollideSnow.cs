using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideSnow : MonoBehaviour
{
    public GameObject parameter;
    void Start()
    {
        //DontDestroyOnLoad(parameter);
    }
    void OnTriggerEnter(Collider other)
    {
        PassParameter.number++;  //获取物品数目+1
        PassParameter.snow = true;    // 标记获得雪花
        Debug.Log("是否获取到星星：" + PassParameter.star);
        Debug.Log("是否获取到礼物：" + PassParameter.present);
        Debug.Log("是否获取到雪花：" + PassParameter.snow);

        Destroy(GameObject.Find("Snowflake"));     //碰撞后就销毁物体
        SceneManager.LoadScene("Vuforia");
        //SceneManager.LoadSceneAsync("Vuforia", LoadSceneMode.Additive);
    }
}
