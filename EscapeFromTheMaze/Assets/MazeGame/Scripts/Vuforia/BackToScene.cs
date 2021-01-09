using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene : MonoBehaviour
{
    private GameObject pm;
    static private GameObject buttons; //Maze中的按钮控件，需要对其进行影藏

    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.Find("Buttons");
        buttons.SetActive(false);   //将迷宫场景的Canvas中的按钮暂时禁用

        pm = GameObject.Find("Parameter");
        DontDestroyOnLoad(pm);

    }

    // Update is called once per frame
    void Update()
    {
        //pm.SetActive(false);
    }

    public void Back()
    {
        buttons.SetActive(true);   //启用被禁用的按钮
        SceneManager.LoadScene("EmptyScene"); //切换场景
    }
}
