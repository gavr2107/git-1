using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(10);
            Destroy(gameObject);
            var enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(10);
            Destroy(gameObject);
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
