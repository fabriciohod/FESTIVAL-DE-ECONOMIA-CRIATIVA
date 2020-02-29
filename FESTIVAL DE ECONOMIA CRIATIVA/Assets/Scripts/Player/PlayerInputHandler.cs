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
        private Rigidbody2D rb;
        private Transform _transform;
        private bool EstaNoChao = true;
        #endregion

        #region Get | Set
        public Rigidbody2D Rb { get => rb; private set => rb = value; }
        public Transform Transform { get => _transform; private set => _transform = value; }
        #endregion

        #region Serialize Field
        [SerializeField][Range (0.15f, 0.60f)] float speed;
        [SerializeField][Range (300f, 700f)] float jumpForce;
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
            if (Input.GetAxisRaw ("Horizontal") > 0) { _transform.Translate (Vector2.right * speed); }

            if (Input.GetAxisRaw ("Horizontal") < 0) { _transform.Translate (Vector2.left * speed); }
        }

        private void Jump ()
        {
            if (Input.GetKeyDown (KeyCode.Space) && EstaNoChao is true) { rb.AddForce (Vector2.up * jumpForce); }
        }

        private void OnCollisionEnter2D (Collision2D collision)
        {
            if (collision.collider.tag is "Chao") { EstaNoChao = true; }
        }

        private void OnCollisionExit2D (Collision2D collision)
        {
            if (collision.collider.tag is "Chao") { EstaNoChao = false; }
        }
    }
}