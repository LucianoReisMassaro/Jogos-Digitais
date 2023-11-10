using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 distancia;
    public GameObject bola;
    void Start()
    {
        distancia = transform.position - bola.transform.position;
    }
    void Update()
    {
        transform.position = bola.transform.position + distancia;
    }
}
