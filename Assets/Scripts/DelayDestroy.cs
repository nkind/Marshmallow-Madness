using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour

{
    [SerializeField] private float _delay = 4.0f;

    void Start()
    {
        Destroy(gameObject, _delay);
        
    }
}
