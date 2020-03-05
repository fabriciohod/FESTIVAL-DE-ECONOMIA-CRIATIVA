using UnityEngine;

//using UnityEngine.SceneManagement;

public class LifeSysteam : MonoBehaviour
{
    public int Life { get; private set; }

    [SerializeField] private int _life;

    private void Awake()
    {
        _life = Life;  
    }

    private void Update()
    {
        if (Life >= 0)
        {
            //TODO: Colocar a sena de derrota aqui | e tirar o comentario do using UnityEngine.SceneManagement
            //SceneManager.LoadScene("");
        }
    }

    public void TomarDano(int dano)
    {
        Life += Life - dano;
    }
}