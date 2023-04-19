using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalInter : MonoBehaviour, InterfaceInteractivo
{
	private Animator _animator;
	private bool _Interaction;
	
	private bool estaDesplegado = false;
	//[SerializeField] private GameObject botonTerminal;
	[SerializeField] private GameObject Terminal;
	public void Programar(){
		Time.timeScale = 0f;
		//botonTerminal.SetActive(false);
		Terminal.SetActive(true);
	}
	public void dejarProgramar(){
		Time.timeScale = 1f;
		//botonTerminal.SetActive(true);
		Terminal.SetActive(false);
	}
	public void ContinuarJuego()      //Accion al salir de la consola
    {
        Desplegar();
    }
	public void Desplegar()
    {
        estaDesplegado = !estaDesplegado;
		Programar();
    }
	void Start()
	{
		_animator = GetComponent<Animator>();
	}
	
	public void Interact()
	{
		_Interaction = true;
		Desplegar();

	}
	
	public bool CanInteract()
	{
		return !_Interaction;
	}
}
