#region Using
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion
namespace Player.InputHandler
{
    [RequireComponent (typeof (Rigidbody2D))]
    public class PlayerInputHandler : MonoBehaviour
    {
        #region Private Field´s
        private Rigidbody2D _rb;
        private Transform _transform;
        private bool _EstaNoChao = true;
        #endregion

        #region Get | Set
        public Rigidbody2D Rb { get => _rb; private set => _rb = value; }
        public Transform Transform { get => _transform; private set => _transform = value; }
        #endregion

        #region Serialize Field
        [SerializeField][Range (0.15f, 0.60f)] float _speed;
        [SerializeField][Range (300f, 700f)] float _jumpForce;
        #endregion

        private void Awake ()
        {
            Rb = GetComponent<Rigidbody2D> ();
            Transform = GetComponent<Transform> ();
        }

        private void Update ()
        {
            MovimentacaoHorizontal ();
            Jump ();
        }

        private void MovimentacaoHorizontal ()
        {
            if (Input.GetAxisRaw ("Horizontal") > 0) { Transform.Translate (Vector2.right * _speed); }

            if (Input.GetAxisRaw ("Horizontal") < 0) { Transform.Translate (Vector2.left * _speed); }
        }

        private void Jump ()
        {
            if (Input.GetKeyDown (KeyCode.Space) && EstaNoChao is true) { rb.AddForce (Vector2.up * _jumpForce); }
        }

        private void OnCollisionEnter2D (Collision2D collision)
        {
            if (collision.collider.tag is "Chao") { _EstaNoChao = true; }
        }

        private void OnCollisionExit2D (Collision2D collision)
        {
            if (collision.collider.tag is "Chao") { _EstaNoChao = false; }
        }
    }
}
