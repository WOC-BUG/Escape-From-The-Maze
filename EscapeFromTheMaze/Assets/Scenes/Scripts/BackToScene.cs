using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene : MonoBehaviour
{
    private GameObject pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Parameter");
        GameObject.DontDestroyOnLoad(pm);
    }

    // Update is called once per frame
    void Update()
    {
        //pm.SetActive(false);
    }

    public void Back()
    {
        SceneManager.LoadScene("EmptyScene"); //切换场景
    }
}
