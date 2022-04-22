using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDestroy : MonoBehaviour
{

    public GameObject particlePrefab;
    public int score = 0;
    private GameManager gm;

    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Projectile")
        {
            Debug.Log("Hit by projectile");
            Destroy(other.gameObject);
            Explode();
            gm.UpdateScore(100);
            Destroy(this.gameObject);
            

        }

        Explode();
        Destroy(this.gameObject);




    }

    void Explode()
    {
        GameObject firework = Instantiate(particlePrefab, transform.position, Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }

    
}
