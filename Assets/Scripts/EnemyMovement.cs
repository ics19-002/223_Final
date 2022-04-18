using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private float speed = 120f;
    public GameObject enemy;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
        enemy.transform.LookAt(target.transform);
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


    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
