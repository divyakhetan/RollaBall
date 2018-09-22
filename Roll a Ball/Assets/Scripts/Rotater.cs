//any collider with a rigid body attached is said to be dynamic. hence we need to add a rigid body. tick gravity and kinematics
// std rigid bodies are moved by physics forces. Kinematic rigid bodies are moved using their transform
// the floor, wall are static collider since we dont want it to disappear when anything collides 
// to make dynamic we to select the IsTrigger option from the BoxCollider 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {


	void Update () {
		transform.Rotate (new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
