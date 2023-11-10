using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jogador : MonoBehaviour
{
    public float velocidade = 30;
    public GameObject chao;
    private Rigidbody rb;
    public float forcaPulo = 25;
    private bool tocouChao = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float movimentoLados = Input.GetAxis("Horizontal");
        float movimentoFrente = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoLados, 0, movimentoFrente);
        rb.AddForce(movimento * velocidade);

        if (Input.GetKeyDown(KeyCode.Space) && tocouChao)
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == chao)
        {
            tocouChao = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == chao)
        {
            tocouChao = false;
        }
    }
}