using UnityEngine;

namespace Player.Script
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private GameObject preFab;
        [SerializeField] private Transform arma;

        public GameObject Atirando(bool bind) => Instantiate(preFab, arma.position, arma.rotation);

        public void FlipGun() => arma.Rotate(0f, 180f, 0f);

        public void ReverseFlipGun() => arma.Rotate(0f, 0f, 0f);
    }
}