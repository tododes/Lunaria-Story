using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterBehaviour : InteractBehaviour {

	[SerializeField] private float multiplier;

	public UnderwaterBehaviour(float multiplier){
		this.multiplier = multiplier;
	}

	#region InteractBehaviour implementation

	public void OnStartInteract (Character character)
	{
		character.modifySpeedWithMultiplier (1f - multiplier);
	}

	public void OnStayInteract (Character character)
	{
		
	}

	public void OnStopInteract (Character character)
	{
		character.modifySpeedWithMultiplier (1f / (1f - multiplier));
	}

	#endregion



}
