using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public GameObject bola;

    void Update()
    {
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == bola)
        {
            GameObject.Find("Pontos").GetComponent<Pontos>().pontos += 1;
            Destroy(this.gameObject);
        }
    }
}
