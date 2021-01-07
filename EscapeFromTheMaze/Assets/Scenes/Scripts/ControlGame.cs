using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlGame : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit(); //退出游戏
    }

    public void Restart()
    {
        SceneManager.LoadScene("Maze"); //重新加载场景
    }
}
