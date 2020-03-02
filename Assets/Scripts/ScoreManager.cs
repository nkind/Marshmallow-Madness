using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] private int _score;

    [SerializeField] private Text _scoreDisplay;

    void Update()
    {
        _scoreDisplay.text = _score.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            _score++;
            Debug.Log(_score);
        }
    }
}
