using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMaze : MonoBehaviour
{
    private GameObject loadScene;
    // Start is called before the first frame update
    void Start()
    {
        loadScene = GameObject.Find("Parameter");
    }

    // Update is called once per frame
    void Update()
    {
        //捡到某个物品后，场景中的物品销毁
        if (loadScene.GetComponent<PassParameter>().star == true)
            Destroy(GameObject.Find("7-Tip-Star"));
        if (loadScene.GetComponent<PassParameter>().present == true)
            Destroy(GameObject.Find("Present-01"));
        if (loadScene.GetComponent<PassParameter>().snow == true)
            Destroy(GameObject.Find("Snowflake"));
    }
}
