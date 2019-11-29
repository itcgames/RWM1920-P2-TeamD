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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform != null)
            {
                if (hit.transform.tag == "PipeLever")
                {
                    Debug.Log("pipe lever works");
                    pipeScript.toggleActive();
                }
                else if (hit.transform.tag == "ConveyorLever")
                {
                    cog1Rotate.ToggleRight();
                    cog2Rotate.ToggleRight();
                    conveyorBelt.toggleEndpoint();
                }
            }
        }
    }

    private void printName(GameObject go)
    {
        if (Input.GetMouseButtonDown(0) && this.tag == "PipeLever")
        {
            leverSource.Play();
            Debug.Log("pipe lever works");
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
