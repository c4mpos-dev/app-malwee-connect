using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAreaAnimation : MonoBehaviour
{
    public Animator perfil;

    public void InformarArea()
    {
        perfil.SetBool("Ativo", true);
    }

    public void RecolherArea()
    {
        perfil.SetBool("Ativo", false);
    }
}
