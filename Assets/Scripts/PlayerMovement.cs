using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20.0f;
    public bool isActive = true;

    [SerializeField] private float xRange = 10f;
    [SerializeField] private float yRange = 5f;

    private Vector3 homePos;

    private void Awake()
    {
        homePos = transform.position;
    }

    void Start()
    {

    }
    void Update()
    {
        if (isActive)
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            gameObject.transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);


            float clampedX = transform.position.x;
            float clampedY = transform.position.y;

            if (transform.position.x > homePos.x + xRange || transform.position.x < homePos.x - xRange)
            {
                clampedX = Mathf.Clamp(transform.position.x, homePos.x - xRange, homePos.x + xRange);
            }
            if (transform.position.y > homePos.y + yRange || transform.position.y < homePos.y - yRange)
            {
                clampedY = Mathf.Clamp(transform.position.y, homePos.y - yRange, homePos.y + yRange);
            }

            Vector3 clampedPos = new Vector3(clampedX, clampedY, transform.position.z);
            transform.position = clampedPos;

        }

    }
}
