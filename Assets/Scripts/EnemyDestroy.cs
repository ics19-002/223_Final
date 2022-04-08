using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    public GameObject particlePrefab;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Projectile")
        {
            Debug.Log("Hit by projectile");
            Destroy(other.gameObject);
            Explode();
            Destroy(this.gameObject);
            

        }

        void Explode()
        {
            GameObject firework = Instantiate(particlePrefab, transform.position, Quaternion.identity);
            firework.GetComponent<ParticleSystem>().Play();
        }
    }
}
