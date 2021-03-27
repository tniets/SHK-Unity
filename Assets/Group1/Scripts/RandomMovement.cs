using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _speed;

    private Vector3 _target;

    private void Start()
    {
        PickNextTarget();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (transform.position == _target)
            PickNextTarget();
    }

    private void PickNextTarget()
    {
        _target = Random.insideUnitCircle * _radius;
    }
}
