using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;

    [SerializeField]
    private float yVal;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != 4)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yVal);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -4)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yVal);
            transform.position = targetPos;
        }
    }
}
