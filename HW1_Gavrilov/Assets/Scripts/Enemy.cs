using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _hp;
    [SerializeField] private GameObject _enemy = null;
    [SerializeField] private Transform _spawnPE = null;

    public void TakeDamage(int damage)
    {
        _hp -= damage;
        Debug.Log(" " + _hp);
        if (_hp <= 0)
        {
            Destroy(gameObject);
            Instantiate(_enemy, _spawnPE.position, _spawnPE.rotation);
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
