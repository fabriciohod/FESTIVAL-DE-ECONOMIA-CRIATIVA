using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(EntityComponet))]
    public class PlayerInputHandler : MonoBehaviour
    {
        #region Field´s

        public bool EstaNoChao { get; private set; } = true;
        public float Axis { get; private set; }
        private EntityComponet _playerComponets;
        private PlayerAttack _attack;

        #endregion

        #region Serialize Field

        [SerializeField] [Range(0f, 0.60f)] private float _speed ;
        [SerializeField] private float _jumpForce;

        #endregion

        private void Awake()
        {
            _attack = GetComponent<PlayerAttack>();
            _playerComponets = GetComponent<EntityComponet>();
        }

        private void Update()
        {
            MovimentacaoHorizontal(Input.GetAxisRaw("Horizontal"), _playerComponets.Transform);
            Jump(Input.GetKeyDown(KeyCode.Space), _playerComponets.Rb);
            _attack.Atirando(Input.GetKeyDown(KeyCode.Z));
        }

        private void MovimentacaoHorizontal(float axis, Transform transformP)
        {
            Axis = axis;
            if (axis > 0)
            {
                transformP.Translate(Vector2.right * _speed);
            }

            if (axis < 0)
            {
                transformP.Translate(Vector2.left * _speed);
            }
        }

        private void Jump(bool bind, Rigidbody2D rb)
        {
            if (bind is true && EstaNoChao is true)
            {
                rb.AddForce(Vector2.up * _jumpForce);
            }
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