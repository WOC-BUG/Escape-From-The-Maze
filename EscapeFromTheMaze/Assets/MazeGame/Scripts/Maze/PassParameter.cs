using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// 改对象用于在场景中传递参数
public class PassParameter : MonoBehaviour
{
    public int number = 0;   //获取物品数量

    //标记当前已获取的是哪个物品
    public bool star = false;
    public bool present = false;
    public bool snow = false;

    public float time = 0;  //计时
    public bool finishGame = false;    //是否正常通关

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //Debug.Log(time);
    }
}
