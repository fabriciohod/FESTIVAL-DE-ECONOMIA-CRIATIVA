using System;
using UnityEngine;

namespace Player.Script
{
    public class PlayerAnimController : MonoBehaviour
    {
        #region Field´s

        private PlayerInputHandler _playerInputHandler;
        private EntityComponet _playercComponet;

        #endregion

        #region AnimString´s

        private readonly int _estaPulando = Animator.StringToHash("EstaPulando");
        private readonly int _estaCorrendo = Animator.StringToHash("EstaCorrendo");
        private readonly int _tiroCorrendo = Animator.StringToHash("TiroCorrendo");
        private readonly int _tiroParado = Animator.StringToHash("TiroParado");

        #endregion

        private void Awake()
        {
            _playerInputHandler = GetComponent<PlayerInputHandler>();
            _playercComponet = GetComponent<EntityComponet>();
        }

        private void Update()
        {
            AnimAndarAndAttack(_playerInputHandler.Axis, _playerInputHandler.EstaArirando);
            AnimPulo(_playerInputHandler.EstaNoChao);
        }

        private void AnimAndarAndAttack(float axis, bool bind)
        {
            _playercComponet.AnimEntity.SetBool(_estaCorrendo, axis < 0 || (axis > 0 ? true: false));
            if (axis > 0)
            {
                _playercComponet.TransformEntity.localScale = new Vector3(1, 1, 1);
                if (bind == true) _playercComponet.AnimEntity.SetBool(_tiroCorrendo, true);
            }
            else if (axis < 0)
            {
                _playercComponet.TransformEntity.localScale = new Vector3(-1, 1, 1);
                if (bind == true) _playercComponet.AnimEntity.SetBool(_tiroCorrendo, true);
            }
            else //TODO: arrumar o timing da animção do tirro parado
            {
                _playercComponet.AnimEntity.SetBool(_tiroParado, bind == true ? true : false);
                _playercComponet.AnimEntity.SetBool(_estaCorrendo, false);
            }
        }

        private void AnimPulo(bool estaNoChao) => _playercComponet.AnimEntity.SetBool(_estaPulando, estaNoChao == false ? true : false);
    }
}