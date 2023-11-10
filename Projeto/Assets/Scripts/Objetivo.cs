using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour
{
    public GameObject bola;
    public Botoes vitoria;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == bola)
        {
            vitoria.ExibirVitoria();
            Time.timeScale = 0;
        }
    }
}
