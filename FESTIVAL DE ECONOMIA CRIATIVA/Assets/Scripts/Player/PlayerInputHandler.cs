using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(EntityComponet))]
    public class PlayerInputHandler : MonoBehaviour
    {
        #region Private Field´s
        private bool _estaNoChao = true;
        private EntityComponet _playerComponets;
        #endregion

        #region Serialize Field
        [SerializeField] [Range(0.15f, 0.60f)] private float _speed = 0.15f;
        [SerializeField] [Range(300f, 700f)] private float _jumpForce = 300f;
        #endregion

        private void Awake()
        {
            _playerComponets = GetComponent<EntityComponet>();
        }

        private void Update()
        {
            MovimentacaoHorizontal(Input.GetAxisRaw("Horizontal"), _playerComponets.Transform);
            Jump(Input.GetKeyDown(KeyCode.Space), _playerComponets.Rb);    
        }

        private void MovimentacaoHorizontal(float axis, Transform transform)
        {
            if (axis > 0)
            {
                transform.Translate(Vector2.right * _speed);
            }

            if (axis < 0)
            {
                transform.Translate(Vector2.left * _speed);
            }
        }

        private void Jump(bool bind, Rigidbody2D rb)
        {
            if (bind is true && _estaNoChao is true)
            {
                rb.AddForce(Vector2.up * _jumpForce);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag is "Chao")
            {
                _estaNoChao = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.tag is "Chao")
            {
                _estaNoChao = false;
            }
        }
    }
}