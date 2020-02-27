using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public int _damage = 1;

    [SerializeField]
    private float _speed;

    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player takes damage
            other.GetComponent<Player>()._health -= _damage;
            Debug.Log(other.GetComponent<Player>()._health);
            Destroy(gameObject);
        }
    }


}
