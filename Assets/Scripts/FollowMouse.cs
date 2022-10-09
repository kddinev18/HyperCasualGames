using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
	[SerializeField] private float distance = 1.0f;
	[SerializeField] private bool useInitalCameraDistance = false;
	private bool isStarted = false;
	private float actualDistance;

	// Use this for initialization
	void Start ()
	{
		if(useInitalCameraDistance)
		{
			Vector3 toObjectVector = transform.position - Camera.main.transform.position;
			Vector3 linearDistanceVector = Vector3.Project(toObjectVector,Camera.main.transform.forward);
			actualDistance = linearDistanceVector.magnitude;
		}
		else
		{
			actualDistance = distance;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton(0))
		{
			isStarted = true;
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = actualDistance;
			transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
		}
		if(isStarted && Input.GetMouseButtonUp(0))
        {
			Debug.Log("game over");
			//end game
        }
	}
}
