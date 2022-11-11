using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] private Coin _goldCoin;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;
    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        for (int i = 0; i < _points.Length; i++)
        {
            Instantiate(_goldCoin, _points[i].transform.position, Quaternion.identity);
        }
    }
}
