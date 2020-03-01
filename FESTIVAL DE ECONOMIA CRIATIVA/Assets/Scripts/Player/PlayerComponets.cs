#region Using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion
    public class PlayerComponets : MonoBehaviour
    {
        Rigidbody2D _rb;
        Transform _transform;
        SpriteRenderer _render;

        public Rigidbody2D Rb { get => _rb; private set => _rb = value; }
        public Transform Transform { get => _transform; private set => _transform = value; }
        public SpriteRenderer Render { get => _render; private set => _render = value; }

        void Awake ()
        {
            Rb = GetComponent<Rigidbody2D>();
            Transform= GetComponent<Transform>();
            Render = GetComponent<SpriteRenderer>();
        }

    }
