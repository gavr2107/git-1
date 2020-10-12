using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrel : MonoBehaviour
{
    [SerializeField] private Transform hero;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, hero.position) < 5)
        {
            transform.LookAt(hero);
        }   
    }
}
