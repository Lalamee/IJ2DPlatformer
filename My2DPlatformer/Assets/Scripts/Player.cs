using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedRun;
    [SerializeField] private float _speedJump;

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
            transform.Translate(_speedRun * Time.deltaTime,0,0 );
        
        if(Input.GetKey(KeyCode.A))
            transform.Translate(_speedRun * Time.deltaTime * -1,0,0 );
        
        if(Input.GetKey(KeyCode.W))
            transform.Translate(0,_speedJump * Time.deltaTime,0 );
        
    }
}
