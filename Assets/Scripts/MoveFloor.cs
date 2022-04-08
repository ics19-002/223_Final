using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField]private float speed = 30f;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.back * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.z < startPos.z - 300)
        {
            transform.position += new Vector3(0, 0, 300);
        }
    }
}
