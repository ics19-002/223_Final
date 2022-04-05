using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 60f;
    public GameObject enemy;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 direction = enemy.transform.position - target.transform.position;

        direction = -direction.normalized;

        enemy.transform.position += direction * Time.deltaTime * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter trigger");
        if (other.tag == "Endpoint")
        {
            Debug.Log("hit end");
            Destroy(gameObject);
        }

        else if (other.tag == "Projectile")
        {
            Debug.Log("Hit by projectile");
            Destroy(gameObject);
            
        }
    }
}
