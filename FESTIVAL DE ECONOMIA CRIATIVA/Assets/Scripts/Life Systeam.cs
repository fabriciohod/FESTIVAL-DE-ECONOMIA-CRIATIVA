using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class LifeSysteam : MonoBehaviour
{
    public float Life { get; private set; }

    void Start()
    {
        Life = 10;
    }

   
    void Update()
    {
        if (Life >= 0)
        {
            SceneManager.LoadScene("");
        }

    }
}
