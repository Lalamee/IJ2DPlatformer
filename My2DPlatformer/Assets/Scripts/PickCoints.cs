using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PickCoints : MonoBehaviour
{
    private int _countCoints = 0;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            _countCoints++;
            Debug.Log(_countCoints + " монет у игрока");
            
        }
    }
}
