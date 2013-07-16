using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
	
	public float _moveSpeed = 5.0f;
	public float _upDownRange = 60.0f;
	public float _mouseSensitivity = 5.0f;
	public float _jumpSpeed = 5;
	
	
	float _vertitalRotation = 0;
	
	float _verticalVelocity = 0;
	CharacterController cc;
	
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		cc = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//X Rotation
		float rotX = Input.GetAxis ("Mouse X");
		transform.Rotate(0,rotX,0);

		
		//movement
		float forwardSpeed = Input.GetAxis("Vertical") * _moveSpeed;
		float sideSpeed = Input.GetAxis("Horizontal") * _moveSpeed;
		
		_verticalVelocity += Physics.gravity.y * Time.deltaTime;
		
		
		if(cc.isGrounded){
			if(Input.GetButton("Jump")){
			_verticalVelocity = _jumpSpeed;	
			}
		}
		
		Vector3 speed = new Vector3(sideSpeed,_verticalVelocity,forwardSpeed);
		
		speed = transform.rotation * speed;
	
		
		cc.Move(speed * Time.deltaTime);
	
	}
}
