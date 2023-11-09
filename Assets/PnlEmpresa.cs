using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PnlEmpresa : MonoBehaviour
{
    public GameObject panelCurso;
    public GameObject panelEmpresa;
    public GameObject panelLogin;

    public void AbrirCurso()
    {
        panelCurso.SetActive(true);
        panelEmpresa.SetActive(false);
    }

    public void VoltarParaTelaLogin()
    {
        panelLogin.SetActive(true);
        panelEmpresa.SetActive(false);
        panelCurso.SetActive(false);
    }
}
