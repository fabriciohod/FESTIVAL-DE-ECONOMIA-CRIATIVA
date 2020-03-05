using UnityEngine;

public class FlipTranform : MonoBehaviour
{
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }
    [ContextMenu("teste Flip")]
    public void Flip()
    {
        _transform.SetPositionAndRotation(new Vector3(_transform.position.x * -1, _transform.position.y, 0),
            Quaternion.Euler(0f, 180f, 0));
        
    }
    [ContextMenu("teste InverseFlip")]
    public void InverseFlip()
    {
        _transform.SetPositionAndRotation(new Vector3(_transform.position.x * 1, _transform.position.y, 0),
            Quaternion.Euler(0f, 0f, 0));
    }
}