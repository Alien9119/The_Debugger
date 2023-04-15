using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalInter : MonoBehaviour, InterfaceInteractivo
{
	private Animator _animator;
	private bool _Interaction;
	
	void Start()
	{
		_animator = GetComponent<Animator>();
	}
	
	public void Interact()
	{
		_Interaction = true;
		_animator.SetTrigger("In");
	}
	
	public bool CanInteract()
	{
		return !_Interaction;
	}
}
