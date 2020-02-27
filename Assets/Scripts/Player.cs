using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Global variables always start with '_'
    private Vector2 _targetPos;

    [SerializeField]
    private float _yVal; // amount to move up or down

    [SerializeField]
    private float _maxHeight;

    [SerializeField]
    private float _minHeight;

    [SerializeField]
    private float _speed; // movement speed

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != _maxHeight)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y + _yVal);
            // transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != _minHeight)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y - _yVal);
            // transform.position = targetPos;
        }
    }
}
