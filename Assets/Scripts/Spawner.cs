using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] _obstaclePatterns;

    // Spawn timer manipulators 
    private float _spawnTimer;
    [SerializeField] private float _startSpawnTimer;
    [SerializeField] private float _decreaseTime;
    [SerializeField] private float _minTime = 0.65f;

    void Update()
    {
        if (_spawnTimer <= 0)
        {
            int rand = Random.Range(0, _obstaclePatterns.Length); // Pick a random pattern to spawn

            Instantiate(_obstaclePatterns[rand], transform.position, Quaternion.identity); // spawn with no rotation
            
            _spawnTimer = _startSpawnTimer;

            if (_startSpawnTimer > _minTime)
            {
                _startSpawnTimer -= _decreaseTime;
            }
        }
        else
        {
            _spawnTimer -= Time.deltaTime;
        }
    }

    


}
