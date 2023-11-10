using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public GameObject bola;
    public Botoes fimJogo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == bola)
        {
            fimJogo.Exibir();
            Time.timeScale = 0;
        }
    }
}
