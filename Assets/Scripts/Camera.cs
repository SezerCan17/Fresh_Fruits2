
using System.Collections;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public Transform target;
	public Transform rightTarget;
	public Transform centerTarget;
	public Transform leftTarget;
	public float movementTime = 1;
	public float rotationSpeed = 0.1f;

	bool atRight;
	bool atCenter = true;
	bool atLeft;

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
		if(atCenter)
        {
			target = rightTarget;
			atCenter = false;
			atRight = true;
		}
		if(atLeft)
        {
			target = centerTarget;
			atLeft = false;
			atCenter = true;
        }
		
    }

	public void LeftLook()
    {
		if (atCenter)
		{
			target = leftTarget;
			atCenter = false;
			atLeft = true;
		}
		if (atRight)
		{
			target = centerTarget;
			atRight = false;
			atCenter = true;
		}
	}
}

