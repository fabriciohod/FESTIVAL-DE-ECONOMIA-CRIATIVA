using System;
using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _velociade;
    [SerializeField] private int _dano;
    [SerializeField] private int _tempoParaDestroir = 4;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = transform.right * _velociade;
        StartCoroutine(DestroirObj(_tempoParaDestroir));
    }

    //TODO: Implemnetar dano
    private IEnumerator DestroirObj(int tempo)
    {
        yield return new WaitForSecondsRealtime(tempo);
        Destroy(gameObject);
    }
}