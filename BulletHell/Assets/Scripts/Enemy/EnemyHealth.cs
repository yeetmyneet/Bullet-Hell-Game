using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyHealth = 10;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] GameObject prefab;
    [SerializeField] bool dropsItem = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                if (dropsItem == true)
                {
                    GameObject crate = Instantiate(prefab, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                if (dropsItem == true)
                {
                    GameObject crate = Instantiate(prefab, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
