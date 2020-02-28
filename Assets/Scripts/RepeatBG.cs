using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    // speed of background movement
    [SerializeField] private float _speed;

    // For looping the background
    [SerializeField] private float _endX;
    [SerializeField] private float _startX;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x <= _endX)
        {
            Vector2 position = new Vector2(_startX, transform.position.y);
            transform.position = position;
        }
    }
}
