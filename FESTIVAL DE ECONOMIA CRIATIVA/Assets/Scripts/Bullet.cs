using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _velociade;
    [SerializeField] private int _dano;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = transform.right * _velociade;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //TODO: Implemnetar dano e detruir os PreFabs depois de um tempo
        throw new System.NotImplementedException();
    }

    
}