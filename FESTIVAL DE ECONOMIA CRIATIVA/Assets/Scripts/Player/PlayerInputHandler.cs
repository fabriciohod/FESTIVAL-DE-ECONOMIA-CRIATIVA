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
        private bool EstaNoChao = true;
        #endregion

        #region Serialize Field
        [SerializeField][Range (0.15f, 0.60f)] float speed = 0.15f;
        [SerializeField][Range (300f, 700f)] float jumpForce = 300f;
        [SerializeField] private PlayerComponets PlayerComponets;
        #endregion

        private void Update ()
        {
            MovimentacaoHorizontal(Input.GetAxisRaw("Horizontal"), PlayerComponets.Transform);
            Jump (Input.GetKeyDown(KeyCode.Space), PlayerComponets.Rb);            
        }

        private void MovimentacaoHorizontal (float axis, Transform transform)
        {
            if (axis > 0) { transform.Translate (Vector2.right * speed); }

            if (axis < 0) { transform.Translate (Vector2.left * speed); }
        }
        private void Jump (bool bind, Rigidbody2D rb)
        {
            if (bind is true && EstaNoChao is true) { rb.AddForce (Vector2.up * jumpForce); }
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
