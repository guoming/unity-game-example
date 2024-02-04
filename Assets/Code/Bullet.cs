using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //3秒后销毁
        GameObject.Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //沿水平方向飞行
        transform.Translate(12* Time.deltaTime,0,0);
    }
}
