using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentRotate : MonoBehaviour
{
    private GameObject pm;
    public GameObject present;
    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Parameter");
    }

    // Update is called once per frame
    void Update()
    {
        if (PassParameter.present == false)
            present.SetActive(false);//隐藏物体
        else
            present.SetActive(true);//显示物体
        transform.Rotate(Vector3.down * Time.deltaTime * speed);
    }
}
