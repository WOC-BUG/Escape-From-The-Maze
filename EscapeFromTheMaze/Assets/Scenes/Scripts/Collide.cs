using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
    static public int number = 0;
    void OnTriggerEnter(Collider other)
    {
        number++;
        Debug.Log(number);
        SceneManager.LoadScene("Vuforia"); //切换场景
    }
}
