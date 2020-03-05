using UnityEditor;
using UnityEngine;

namespace Player
{
    public class PlayerAnimController : MonoBehaviour
    {
        private PlayerInputHandler _input;
        private EntityComponet _playerComponet;
        private readonly int _estaCorrendo = Animator.StringToHash("EstaCorrendo");
        private readonly int _estaPulando = Animator.StringToHash("EstaPulando");

        private FlipTranform _arma;

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _playerComponet = GetComponent<EntityComponet>();
            _arma = GetComponentInChildren<FlipTranform>();
        }

        private void Update()
        {
            AnimAndar(_input.Axis);
            AnimPulo(_input.EstaNoChao);
        }

        private void AnimAndar(float axis)
        {
            if (axis > 0)
            {
                _playerComponet.Render.flipX = false;
                _playerComponet.Anim.SetBool(_estaCorrendo, true);
                _arma.InverseFlip();
            }
            else if (axis < 0)
            {
                _playerComponet.Render.flipX = true;
                _playerComponet.Anim.SetBool(_estaCorrendo, true);
                _arma.Flip();
            }
            else
            {
                _playerComponet.Anim.SetBool(_estaCorrendo, false);
            }
        }

        private void AnimPulo(bool estaNoChao)
        {
            if (estaNoChao is false)
            {
                _playerComponet.Anim.SetBool(_estaPulando, true);
            }
            else
            {
                _playerComponet.Anim.SetBool(_estaPulando, false);
            }
        }
    }
}