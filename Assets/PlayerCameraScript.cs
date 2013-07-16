using UnityEngine;
using System.Collections;

public class PlayerCameraScript : MonoBehaviour {
	
	Vector3 _thirdPersonCameraPos; //y 1.5 z -5
	Vector3 _firstPersonCameraPos;
	Vector3 _curCameraPos;
	
	public GameObject _player ;

	void Start () {
		_thirdPersonCameraPos = new Vector3(0,1.5f,-5.0f);
		_firstPersonCameraPos = _player.transform.position;
		
		_curCameraPos = _thirdPersonCameraPos;
		
		transform.position = _curCameraPos;
	}
	

	void Update () {
	
		
		transform.position = _player.transform.position + _thirdPersonCameraPos;
		transform.RotateAround(_player.transform.position,_player.transform.rotation.y);
	
	}
}
