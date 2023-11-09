using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PnlEmpresa : MonoBehaviour
{
    public GameObject panelCurso;
    public GameObject panelEmpresa;

    public void AbrirCurso()
    {
        panelCurso.SetActive(true);
        panelEmpresa.SetActive(false);
    }
}
