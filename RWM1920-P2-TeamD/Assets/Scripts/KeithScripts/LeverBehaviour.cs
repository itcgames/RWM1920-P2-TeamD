using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    public MartinPipeScript pipeScript;
    public ConveyorBelt conveyorBelt;
    public Rotate cog1Rotate;
    public Rotate cog2Rotate;

    public RotateObj gravBox;
	public AudioSource leverSource;
	public AudioClip leverClip;

    bool leverLeft = true;

    public Sprite Left;
    public Sprite Right;

	private void Start()
	{
		leverSource.clip = leverClip;
	}

    private void Update()
    {
		leverSource.volume = PlayerPrefs.GetFloat("volume");
		if (leverLeft)
        {
            this.GetComponent<SpriteRenderer>().sprite = Left;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = Right;
        }

        //print(leverLeft);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && this.tag == "PipeLever")
        {
            leverSource.Play();
            pipeScript.toggleActive();
            toggleLeverLeft();
        }

        if (Input.GetMouseButtonDown(0) && this.tag == "ConveyorLever")
        {
            leverSource.Play();
            cog1Rotate.ToggleRight();
            cog2Rotate.ToggleRight();
            conveyorBelt.toggleEndpoint();
            toggleLeverLeft();
        }

        if (Input.GetMouseButtonDown(0) && this.tag == "GravityLever")
        {
            leverSource.Play();
            gravBox.rotate90();
            toggleLeverLeft();
        }
    }

    void toggleLeverLeft()
    {
        if(leverLeft)
        {
            leverLeft = false;
        }
        else
        {
            leverLeft = true;
        }

    }
}
