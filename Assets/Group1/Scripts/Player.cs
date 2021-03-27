using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed { get => _speed; set => _speed = value; }

    [SerializeField] private float _speed;
}
