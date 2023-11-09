using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class pnlLogin : MonoBehaviour
{
    public GameObject panelLogin;
    public GameObject panelEmpresa;
    public GameObject panelSelectPF;
    public GameObject panelSelectPJ;
    public GameObject panelSelectPF2;
    public GameObject panelSelectPJ2;
    public GameObject textSenhaError;
    public Text email;
    public Text senha;

    public int verificador;

    public void ButtonEntrar()
    {
        if (email.text != "grupomalwee@malwee.com" || senha.text != "jaejae" || verificador != 1)
        {
            textSenhaError.SetActive(true);
        }
        else
        {
            panelLogin.SetActive(false);
            panelEmpresa.SetActive(true);
        }
    }

    public void SelectPJ()
    {
        panelSelectPJ.SetActive(true);
        panelSelectPF.SetActive(false);
        panelSelectPF2.SetActive(false);
    }

    public void DeselectPJ()
    {
        panelSelectPJ.SetActive(false);
        panelSelectPF.SetActive(false);
    }

    public void SelectPF()
    {
        panelSelectPJ.SetActive(false);
        panelSelectPF.SetActive(true);
        panelSelectPJ2.SetActive(false);
        verificador = 0;
    }

    public void DeselectPF()
    {
        panelSelectPJ.SetActive(false);
        panelSelectPF.SetActive(false);
    }

    public void ClickPJ()
    {
        panelSelectPJ2.SetActive(true);
        panelSelectPF2.SetActive(false);
        verificador = 1;
    }

    public void ClickPF()
    {
        panelSelectPJ2.SetActive(false);
        panelSelectPF2.SetActive(true);
    }
}
