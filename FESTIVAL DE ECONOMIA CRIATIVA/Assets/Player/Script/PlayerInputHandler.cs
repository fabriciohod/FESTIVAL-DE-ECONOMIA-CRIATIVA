using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player.Script
{
    [RequireComponent(typeof(EntityComponet))]
    public class PlayerInputHandler : MonoBehaviour
    {
        #region Field´s

        private EntityComponet _playerComponets;
        private PlayerAttack _attack;

        #endregion

        #region Get´s | Set´s

        public bool EstaNoChao { get; private set; } = true;
        public float Axis { get; private set; }
        public bool EstaArirando { get; private set; }

        #endregion

        #region Serialize Field

        [FormerlySerializedAs("_speed")] [SerializeField] [Range(0f, 0.60f)]
        private float speed;

        [FormerlySerializedAs("_jumpForce")] [SerializeField]
        private float jumpForce;

        #endregion

        private void Awake()
        {
            _attack = GetComponent<PlayerAttack>();
            _playerComponets = GetComponent<EntityComponet>();
        }

        private void Update()
        {
            #region Movimentacao
            MovimentacaoHorizontal(Input.GetAxisRaw("Horizontal"), _playerComponets.TransformEntity);
            Jump(Input.GetKeyDown(KeyCode.Space), _playerComponets.RigidbodyEntity);
            #endregion

            #region Ataque
            _attack.Atirando(EstaArirando = Input.GetKeyUp(KeyCode.Z));
            _attack.GunTransform(_playerComponets.TransformEntity);
            #endregion
        }

        private void MovimentacaoHorizontal(float axis, Transform transformP)
        {
            Axis = axis;
            if (axis > 0)
            {
                transformP.Translate(Vector2.right * speed);
            }
            if (axis < 0)
            {
                transformP.Translate(Vector2.left * speed);
            }
        }

        private void Jump(bool bind, Rigidbody2D rb)
        {
            if (bind && EstaNoChao) rb.AddForce(Vector2.up * jumpForce);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Chao"))
            {
                EstaNoChao = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Chao"))
            {
                EstaNoChao = false;
            }
        }
    }
}