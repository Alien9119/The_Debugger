using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooglePanelConfig : MonoBehaviour
{
    //Referencia al panel de configuración
    public GameObject PanelConfig;
    //Estatus del panel de configuración
    private bool configActiva = false;
    
    public void Toogle()
    {
        configActiva = !configActiva;
        PanelConfig.SetActive(configActiva);
    }
}
