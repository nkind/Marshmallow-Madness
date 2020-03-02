using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public int _damage = 1;

    [SerializeField] private float _speed;

    public GameObject _effect; // particle effect

    public GameObject _fireSound;


    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(_fireSound, transform.position, Quaternion.identity);
            
            Instantiate(_effect, transform.position, Quaternion.identity); // Particle effect on collision 

            // player takes damage
            other.GetComponent<Player>()._health -= _damage;
            Debug.Log(other.GetComponent<Player>()._health);
            Destroy(gameObject);
        }
    }


}
