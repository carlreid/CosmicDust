using UnityEngine;
using System.Collections;

public class OrbitPlanet : MonoBehaviour {
	
	GameObject _mySphere;
	float _mass = 100f;
	Vector3 _velocity;
	
	// Use this for initialization
	void Start () {
		_mySphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		_mySphere.transform.position = new Vector3(0, 0, Random.Range(7, 50));
		_mySphere.transform.RotateAround(Vector3.zero, Vector3.up, Random.Range(0, 2));
		_mySphere.transform.localScale *= Random.Range(1, 5);
		
		_velocity = Vector3.Cross(Vector3.up, _mySphere.transform.position - Vector3.zero).normalized * 10;
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 totalForce = (_velocity + (Vector3.zero - _mySphere.transform.position).normalized) / _mass;
		_mySphere.transform.position += totalForce;
		
		_velocity = Vector3.Cross(Vector3.up, _mySphere.transform.position - Vector3.zero).normalized;
		
	}
}
