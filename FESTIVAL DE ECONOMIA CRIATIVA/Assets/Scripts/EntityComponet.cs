using UnityEngine;

[RequireComponent(typeof(LifeSysteam),typeof(Rigidbody2D))]
public class EntityComponet : MonoBehaviour
{
    public Rigidbody2D Rb { get; private set; }

    public Transform Transform { get; private set; }

    public SpriteRenderer Render { get; private set; }

    public Animator Anim { get; private set; }
        
    public LifeSysteam Health { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
        Transform = GetComponent<Transform>();
        Render = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
        Health = GetComponent<LifeSysteam>();
    }
}