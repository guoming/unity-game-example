using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform _playerTransform;
    
    // Start is called before the first frame update
    void Start()
    { 
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localPosition = new Vector3(_playerTransform.position.x, _playerTransform.position.y, -10);
    }
    
    
  
    
}
