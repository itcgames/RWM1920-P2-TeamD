using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    public MartinPipeScript pipeScript;
    public ConveyorBelt conveyorBelt;
    public Rotate cog1Rotate;
    public Rotate cog2Rotate;

	public AudioSource leverSource;
	public AudioClip leverClip;

	private void Start()
	{
		leverSource.clip = leverClip;
	}

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && this.tag == "PipeLever")
        {
            leverSource.Play();
            Debug.Log("pipe lever works");
            pipeScript.toggleActive();
        }

        if (Input.GetMouseButtonDown(0) && this.tag == "ConveyorLever")
        {
            leverSource.Play();
            cog1Rotate.ToggleRight();
            cog2Rotate.ToggleRight();
            conveyorBelt.toggleEndpoint();
        }
    }
}
