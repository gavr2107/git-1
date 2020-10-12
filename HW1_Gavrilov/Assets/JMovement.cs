using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JMovement : MonoBehaviour
{
    [SerializeField] private float _speed; // Скорость движения, а в дальнейшем ускорение
    [SerializeField] private Vector3 _direction; // Направление движения
    [SerializeField] private GameObject _mine = null;
    [SerializeField] private Transform _spawnPosition = null;
    [SerializeField] private Vector3 _target;



    private List<int> keys = null;

    // Start is called before the first frame update
    void Start()
    {
        keys = new List<int>();
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        _target.Set(_direction.x, 0f, _direction.z);
        _target.Normalize();

        Vector3 newDir = Vector3.RotateTowards(transform.forward, _target, _speed * Time.deltaTime, 0.0F);

        transform.rotation = Quaternion.LookRotation(newDir);

        

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_mine, _spawnPosition.position, _spawnPosition.rotation);
        }
    }
    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

    public void AddKey(int keyID)
    {
        keys.Add(keyID);
    }

    public bool HaveKey(int keyID)
    {
        if (keys.Contains(keyID))
            return true;
        else
            return false;
    }
}
