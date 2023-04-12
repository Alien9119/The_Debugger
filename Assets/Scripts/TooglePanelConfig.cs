using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooglePanelConfig : MonoBehaviour
{
    //Referencia al panel de configuraci�n
    public GameObject PanelConfig;
    //Estatus del panel de configuraci�n
    private bool configActiva = false;
    
    public void Toogle()
    {
        configActiva = !configActiva;
        PanelConfig.SetActive(configActiva);
    }
}
