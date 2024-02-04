using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

   
    // Start is called before the first frame update
    void Start()
    { 
        _rigidbody2D = GetComponent<Rigidbody2D>();
   
    }

    // Update is called once per frame
    void Update()
    {
        //左右移动
        _rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, _rigidbody2D.velocity.y);
        
        //跳跃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, 10);
        }
           
        
        //反射子弹
        if (Input.GetKeyDown(KeyCode.F))
        {
            //加载子弹
            var bullet = Resources.Load<GameObject>("Bullet");
            
            //设置子弹出生位置
            GameObject.Instantiate(bullet, transform.position, Quaternion.identity);   
        }
    }

    //产生碰撞
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            SceneManager.LoadScene("GameOver");
        }
        
        else if (other.gameObject.CompareTag("Finish"))
        {
            
            SceneManager.LoadScene("GameFinish");

        }
    }
}
