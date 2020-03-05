using UnityEngine;

namespace Player
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
            if (bind is true)
            {
                Instantiate(_preFab, _arma.position, _arma.rotation);
            }
        }
    }
}