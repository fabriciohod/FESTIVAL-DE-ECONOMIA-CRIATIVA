using UnityEngine;

namespace Player.Script
{
    public class PlayerAnimController : MonoBehaviour
    {
        #region Field´s
        private PlayerInputHandler _input;
        private Animator _playerAnimator;
        private Transform _playerTransform;
        #endregion

        #region AnimString´s
        private readonly int _estaPulando = Animator.StringToHash("EstaPulando");
        private readonly int _estaCorrendo = Animator.StringToHash("EstaCorrendo");
        #endregion

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _playerAnimator = GetComponent<Animator>();
            _playerTransform = GetComponent<Transform>();
        }

        private void Update()
        {
            AnimAndar(_input.Axis, _playerTransform, _playerAnimator);
            AnimPulo(_input.EstaNoChao, _playerAnimator);
        }

        private void AnimAndar(float axis, Transform transformP, Animator animator)
        {
            if (axis > 0)
            {
                animator.SetBool(_estaCorrendo, true);
                transformP.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (axis < 0)
            {
                animator.SetBool(_estaCorrendo, true);
                transformP.localScale = new Vector3(-1f, 1f, 1f);
            }
            else
            {
                animator.SetBool(_estaCorrendo, false);
            }
        }

        private void AnimPulo(bool estaNoChao, Animator animator) => animator.SetBool(_estaPulando, estaNoChao == false);
    }
}