using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField]private GameObject projectilePrefab;
    [SerializeField] private PlayerMovement pm;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && pm.isActive)
        {
            Instantiate(projectilePrefab, transform.position + new Vector3(0,1.5f,1), Quaternion.identity);
            
        }
    }
}
