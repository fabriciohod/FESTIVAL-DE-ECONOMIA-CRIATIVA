using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerAttack
    {
        [SerializeField] private GameObject _praFab;
        private PlayerInputHandler _input;

        private void Awake()
        {
           
        }

        public void Atirando(bool bind)
        {
            //TODO: implementar attack 
        }
    }
}