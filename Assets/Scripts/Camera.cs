
using System.Collections;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public Transform target;
	public Transform rightTarget; 
	public float movementTime = 1;
	public float rotationSpeed = 0.1f;

	Vector3 refPos;
	Vector3 refRot;

	void Update()
	{
		if (!target)
			return;
		//Interpolate Position
		//transform.position = Vector3.SmoothDamp(transform.position, target.position, ref refPos, movementTime);
		//Interpolate Rotation
		transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationSpeed * Time.deltaTime);
	}

	public void RightLook()
    {
		target = rightTarget;
    }
}

