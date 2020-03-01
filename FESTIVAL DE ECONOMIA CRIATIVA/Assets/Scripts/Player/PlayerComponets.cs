#region Using
using UnityEngine;
#endregion
    namespace Assets.Scripts.Player
    {
        public class PlayerComponets : MonoBehaviour
        {
            public Rigidbody2D Rb { get; private set; }

            public Transform Transform { get; private set; }

            public SpriteRenderer Render { get; private set; }

            private void Awake ()
            {
                Rb = GetComponent<Rigidbody2D>();
                Transform= GetComponent<Transform>();
                Render = GetComponent<SpriteRenderer>();
            }

        }
    }
