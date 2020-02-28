using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
 
    private Vector2 _targetPos; // where play wants to move

    [SerializeField] private float _yVal; // amount to move up or down
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;

    [SerializeField] private float _speed; // movement speed

    public int _health = 3;

    void Update()
    {
        if (_health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != _maxHeight)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y + _yVal);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != _minHeight)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y - _yVal);
        }
    }
}
