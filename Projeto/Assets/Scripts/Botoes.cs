using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public GameObject telaInicio;
    public GameObject telaFim;
    public GameObject telaVitoria;
    public GameObject pontos;
    public GameObject textoPontos;
    public GameObject telaCreditos;
    private bool inicioAtivo = true;

    public void Exibir()
    {
        telaFim.gameObject.SetActive(true);
    }

    public void TentarNovamente()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Jogar()
    {
        Time.timeScale = 1;
        telaInicio.SetActive(false);
        inicioAtivo = false;
        textoPontos.SetActive(true);
        pontos.SetActive(true);
    }

    public void Creditos()
    {
        telaInicio.SetActive(false);
        inicioAtivo = false;
        telaCreditos.SetActive(true);
    }

    public void CreditosVoltar()
    {
        telaInicio.SetActive(true);
        inicioAtivo = true;
        telaCreditos.SetActive(false);
    }

    private void CenaCongelada()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (inicioAtivo)
        {
            CenaCongelada();
        }
    }

    public void ExibirVitoria()
    {
        telaVitoria.gameObject.SetActive(true);
    }
}

