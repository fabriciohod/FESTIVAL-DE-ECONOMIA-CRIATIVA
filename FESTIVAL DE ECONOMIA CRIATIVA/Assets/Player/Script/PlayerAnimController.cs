﻿using UnityEngine;

namespace Player.Script
{
    public class PlayerAnimController : MonoBehaviour
    {
        #region Field´s
        private (bool estaNoChao, float axis) _player;
        private EntityComponet _playercComponet;
        private Animator _playerAnimator;
        private Transform _playerTransform;
        #endregion

        #region AnimString´s
        private readonly int _estaPulando = Animator.StringToHash("EstaPulando");
        private readonly int _estaCorrendo = Animator.StringToHash("EstaCorrendo");
        #endregion

        private void Awake()
        {
            var playerInputHandler = GetComponent<PlayerInputHandler>();
            _playercComponet = GetComponent<EntityComponet>();
            _player = (playerInputHandler.EstaNoChao, playerInputHandler.Axis);
            _playerAnimator = _playercComponet.AnimEntity;
            _playerTransform = _playercComponet.transform;
        }

        private void Update()
        {
            AnimAndar(_player.axis, _playerTransform, _playerAnimator);
            AnimPulo(_player.estaNoChao, _playerAnimator);
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