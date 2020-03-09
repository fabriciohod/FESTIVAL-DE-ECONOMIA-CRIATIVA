using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class LifeSysteam : MonoBehaviour
{
    public int Life { get; private set; }
    [FormerlySerializedAs("_life")] [SerializeField] private int life;

    private void Awake()
    {
        life = Life;
    }
    private void Update()
    {
        if (Life <= 0)
        {
            //TODO: Colocar a sena de derrota aqui
            //SceneManager.LoadScene();
        }
    }
    public void TomarDano(int dano) => Life += Life - dano;
}