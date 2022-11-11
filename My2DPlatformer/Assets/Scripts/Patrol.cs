using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform[] _points;
    private SpriteRenderer _renderer;
    private Vector2 _direction;
    private int _currentPoint;
    private int _startPoint = 0;
    private int _endPoint = 1;
    
    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }
    
    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;
            
            if(_currentPoint == _endPoint)
                _renderer.flipX = true;
            else
                _renderer.flipX = false;

            if (_currentPoint >= _points.Length)
                _currentPoint = _startPoint;
        }
    }
}
