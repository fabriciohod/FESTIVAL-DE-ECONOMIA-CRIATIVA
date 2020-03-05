using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerAnimController : MonoBehaviour
    {
        private PlayerInputHandler _input;
        private EntityComponet _playerComponet;

        private void Awake()
        {
            _input = GetComponent<PlayerInputHandler>();
            _playerComponet = GetComponent<EntityComponet>();
        }

        private void Update()
        {
            AnimAndar(_input.Axis);
            AnimPulo(_input.EstaNoChao);
        }

        private void AnimAndar(float _axis)
        {
            if (_axis > 0)
            {
                _playerComponet.Render.flipX = false;
                _playerComponet.Anim.SetBool("EstaCorrendo", true);
            }
            else if (_axis < 0)
            {
                _playerComponet.Render.flipX = true;
                _playerComponet.Anim.SetBool("EstaCorrendo", true);
            }
            else
            {
                _playerComponet.Anim.SetBool("EstaCorrendo", false);
            }
        }

        private void AnimPulo(bool estaNoChao)
        {
        
            if (estaNoChao is false)
            {
                _playerComponet.Anim.SetBool("EstaPulando", true);
            }
            else
            {
                _playerComponet.Anim.SetBool("EstaPulando", false);
            }
            
        }
    }
}