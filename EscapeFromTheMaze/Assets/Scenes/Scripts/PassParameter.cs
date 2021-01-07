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

    private GameObject passObject;
    private static bool isExist;    //是否已经存在DontDestroy的物体
    void Awake()
    {
        //SecurityCamera.ChangeCamera("ARCamera");
        //passObject = GameObject.Find("Parameter");
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
        //    //passObject = GameObject.Find("Parameter");
        //    //passObject.SetActive(true);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
