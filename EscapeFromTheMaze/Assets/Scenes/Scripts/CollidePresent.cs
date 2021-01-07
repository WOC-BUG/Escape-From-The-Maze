using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollidePresent : MonoBehaviour
{
    public GameObject parameter;
    void Start()
    {
        GameObject.DontDestroyOnLoad(parameter);
    }
    void OnTriggerEnter(Collider other)
    {
        parameter.GetComponent<PassParameter>().number++;  //获取物品数目+1
        parameter.GetComponent<PassParameter>().present = true;    // 标记获得礼物
        Debug.Log("是否获取到星星：" + parameter.GetComponent<PassParameter>().star);
        Debug.Log("是否获取到礼物：" + parameter.GetComponent<PassParameter>().present);
        Debug.Log("是否获取到雪花：" + parameter.GetComponent<PassParameter>().snow);

        SceneManager.LoadScene("Vuforia");
    }
}
