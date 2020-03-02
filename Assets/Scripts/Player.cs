using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
 
    private Vector2 _targetPos; // where play wants to move

    [SerializeField] private float _yVal; // amount to move up or down
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;

    [SerializeField] private float _speed; // movement speed

    public int _health = 3;

    public GameObject _effect;

    [SerializeField] private Text _healthDisplay;

    [SerializeField] private GameObject _gameOver;

    public GameObject _moveSound;

    void Update()
    {

        _healthDisplay.text = "HP: " + _health.ToString();

        if (_health <= 0)
        {
            _gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != _maxHeight)
        {
            Instantiate(_moveSound, transform.position, Quaternion.identity);
            Instantiate(_effect, transform.position, Quaternion.identity);
            _targetPos = new Vector2(transform.position.x, transform.position.y + _yVal);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != _minHeight)
        {
            Instantiate(_moveSound, transform.position, Quaternion.identity);
            Instantiate(_effect, transform.position, Quaternion.identity);
            _targetPos = new Vector2(transform.position.x, transform.position.y - _yVal);
        }
    }
}
