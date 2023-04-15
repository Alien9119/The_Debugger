using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInter : MonoBehaviour, InterfaceInteractivo
{
	private Animator _animator;
	private bool _isOpen;
	
	void Start()
	{
		_animator = GetComponent<Animator>();
	}
	
	public void Interact()
	{
		_isOpen = true;
		_animator.SetTrigger("Open");
	}
	
	public bool CanInteract()
	{
		return !_isOpen;
	}
}
