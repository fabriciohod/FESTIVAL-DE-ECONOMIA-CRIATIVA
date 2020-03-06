using UnityEngine;

public class FlipTranform : MonoBehaviour
{
    private Transform _transform;
    private Vector3 _position;


    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _position = _transform.position;
    }

    [ContextMenu("teste Flip")]
    public void Flip()
    {
        _transform.SetPositionAndRotation(new Vector3(_position.x * -1, _position.y, 0),
            Quaternion.Euler(0f, 180f, 0));
    }

    [ContextMenu("teste InverseFlip")]
    public void InverseFlip()
    {
        _transform.SetPositionAndRotation(new Vector3(_position.x * 1, _position.y, 0),
            Quaternion.Euler(0f, 0f, 0));
    }
}