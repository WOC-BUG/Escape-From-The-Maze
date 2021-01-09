using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotate : MonoBehaviour
{
    private GameObject pm;
    public GameObject star;
    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Parameter");
    }

    // Update is called once per frame
    void Update()
    {
        if (PassParameter.star == false)
            star.SetActive(false);//隐藏物体
        else
            star.SetActive(true);//显示物体
        transform.Rotate(Vector3.left * Time.deltaTime * speed);
    }
}