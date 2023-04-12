using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelConfig : MonoBehaviour
{
    //Referencia al panel de configuración
    public GameObject panel_config;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject titulo;
    //Estatus del panel de configuración
    private bool configActiva = false;
    private bool objmenu = false;
    
    public void regresarMenu()
    {
        objmenu = true;
        ToogleC();
    }

    public void ToogleC()
    {
        configActiva = !configActiva;
        panel_config.SetActive(configActiva);
        boton1.SetActive(objmenu);
        boton2.SetActive(objmenu);
        titulo.SetActive(objmenu);
        objmenu = false;
    }
}
