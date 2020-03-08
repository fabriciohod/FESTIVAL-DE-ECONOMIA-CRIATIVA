using System;
using System.Collections;
using UnityEngine;

namespace Player.Script
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private GameObject preFab;
        [SerializeField] private Transform arma;
        public GameObject Atirando(bool bind) => bind == true ? Instantiate(preFab, arma.position, arma.rotation) : null;
        public void GunTransform(Transform player)
        {
            if (player.localScale.Equals(new Vector3(-1,1,1)))
            {
                FlipGun();
            }
            else if (player.localScale.Equals(new Vector3(1,1,1)))
            {
                ReverseFlipGun();
            }
        }
        private void FlipGun() => arma.rotation = Quaternion.Euler(0,180,0);
        private void ReverseFlipGun() => arma.rotation = Quaternion.identity;
    }
}