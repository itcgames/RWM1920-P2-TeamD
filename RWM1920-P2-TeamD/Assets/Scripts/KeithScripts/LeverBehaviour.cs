using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : MonoBehaviour
{
    public MartinPipeScript pipeScript;
    public ConveyorBelt conveyorBelt;
    public Rotate cog1Rotate;
    public Rotate cog2Rotate;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform != null)
            {
                if (this.tag == "PipeLever")
                {
                    pipeScript.toggleActive();
                }
                else if (this.tag == "ConveyorLever")
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
        print(go.name);
    }
}
