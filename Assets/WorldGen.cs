using UnityEngine;
using System.Collections;

public class WorldGen : MonoBehaviour {
	
	public int _numPlanets = 1;
	ArrayList _planets = new ArrayList();
	GameObject _blackHole;
	
	// Use this for initialization
	void Start () {
		_blackHole = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		_blackHole.transform.position = Vector3.zero;
		_blackHole.name = "BlackHoleObject";
		_blackHole.renderer.material.color = Color.black;
		
		for(int planetNum = 0; planetNum < _numPlanets; ++planetNum){
			GameObject newPlanet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			newPlanet.AddComponent("OrbitPlanet");
			_planets.Add(newPlanet);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
