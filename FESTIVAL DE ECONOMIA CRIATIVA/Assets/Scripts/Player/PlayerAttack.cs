using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private GameObject _preFab;
        [SerializeField] private Transform _arma;
        public float velociade;
        private Rigidbody2D rb;
        private PlayerInputHandler _input;


        private void Awake()
        {
        }

        public void Atirando(bool bind)
        {
            if (bind is true)
            {
                GameObject go = Instantiate(_preFab);
            }
        }
    }
}