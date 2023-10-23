using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float chaseDistance = 2.0f;
    [SerializeField] float moveSpeed = 5.0f;
    Vector3 home;
    Rigidbody2D myRigidbody;
    void Start()
    {
        home = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 moveDirection = playerPosition - transform.position;
        if (moveDirection.magnitude < chaseDistance)
        {
            moveDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;
        }
        else
        {
            moveDirection = home - transform.position;
            if (moveDirection.magnitude >= 0.3f)
            {
                moveDirection.Normalize();
                GetComponent<Rigidbody2D>().velocity = moveDirection * moveSpeed;
            }
            else
            {
                transform.position = home;
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
        }
    }
}
