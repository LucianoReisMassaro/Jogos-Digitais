using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public int pontos = 0;
    public GUIStyle estilo;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), pontos.ToString(), estilo);
    }
}
