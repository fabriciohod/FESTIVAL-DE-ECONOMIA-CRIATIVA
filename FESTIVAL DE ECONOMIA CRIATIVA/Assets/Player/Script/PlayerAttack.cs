using UnityEngine;

namespace Player.Script
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private GameObject _preFab;
        [SerializeField] private Transform _arma;
        private PlayerInputHandler _input;
        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
        }
        public void Atirando(bool bind)
        {
            if (bind == true)
            {
                Instantiate(_preFab, _arma.position, _arma.rotation);
            }
        }
        public void FlipGun()
        {
            _arma.Rotate(0f, 180f, 0f);
        }

        public void ReverseFlipGun()
        {
            _arma.Rotate(0f, 0f, 0f);
        }

       
    }
}