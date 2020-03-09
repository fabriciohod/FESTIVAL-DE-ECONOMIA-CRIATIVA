using System;
using System.Collections;
using UnityEngine;

namespace Player.Tiro
{
    public class Bullet : MonoBehaviour
    {
        #region SerializeField´s
        [SerializeField] private float velociade;
        [SerializeField] [HideInInspector] private int dano;
        [SerializeField] private int tempoParaDestroir = 4;
        #endregion 
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            _rb.velocity = transform.right * velociade;
            StartCoroutine(DestroirObj(tempoParaDestroir));
        }
        private IEnumerator DestroirObj(int tempo)
        {
            yield return new WaitForSecondsRealtime(tempo);
            Destroy(gameObject);
        }
        //checando se a colisão e dando dano
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Inimigo"))
            {
                collision.gameObject.GetComponent<LifeSysteam>().TomarDano(4);
            }
        }
    }
}