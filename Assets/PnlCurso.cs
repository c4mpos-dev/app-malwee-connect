using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnlCurso : MonoBehaviour
{
    public GameObject panelCurso;
    public GameObject panelEmpresa;
    public GameObject panelLogin;

    public void VoltarParaTelaEmpresa()
    {
        panelLogin.SetActive(false);
        panelEmpresa.SetActive(true);
        panelCurso.SetActive(false);
    }
}
