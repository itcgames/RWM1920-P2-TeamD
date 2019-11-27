using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParachute : MonoBehaviour
{
	[SerializeField] private GameObject parachute;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
		{
			parachute.SetActive(true);
		}


		parachute.transform.position = gameObject.transform.position + new Vector3(0.0f, 1.2f, 0.0f);

	}
}
