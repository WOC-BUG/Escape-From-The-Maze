using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowRotate : MonoBehaviour
{
    private GameObject pm;
    public GameObject snow;
    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Parameter");
    }

    // Update is called once per frame
    void Update()
    {
        if (PassParameter.snow == false)
            snow.SetActive(false);//隐藏物体
        else
            snow.SetActive(true);//显示物体
        transform.Rotate(Vector3.down * Time.deltaTime * speed);
    }
}
