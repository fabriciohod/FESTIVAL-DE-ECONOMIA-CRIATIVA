using Player.Script;
using UnityEngine;

[RequireComponent(typeof(LifeSysteam), typeof(Rigidbody2D))]
public class EntityComponet : MonoBehaviour
{
    public Rigidbody2D RigidbodyEntity { get; private set; }
    public Transform TransformEntity { get; private set; }
    public SpriteRenderer RenderEntity { get; private set; }
    public Animator AnimEntity { get; private set; }
    public LifeSysteam HealthEntity { get; private set; }

    private void Awake()
    {
        RigidbodyEntity = GetComponent<Rigidbody2D>();
        TransformEntity = GetComponent<Transform>();
        RenderEntity = GetComponent<SpriteRenderer>();
        AnimEntity = GetComponent<Animator>();
        HealthEntity = GetComponent<LifeSysteam>();
    }
}