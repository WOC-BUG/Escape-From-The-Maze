using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideEffect : MonoBehaviour
{
    private GameObject parameter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        parameter = GameObject.Find("Parameter");
    }

    void OnTriggerEnter(Collider other)
    {
        // 设置按钮未按下
        GoForward.isDown = false;
        GoBack.isDown = false;

        PassParameter.finishGame = true;  //标记游戏通关
        SceneManager.LoadScene("Index");    //返回首页
        //SceneManager.LoadSceneAsync("Index", LoadSceneMode.Additive);
    }
}
