var length	: float = 10.0;
var width	: float = 5.0;
var height	: float = 2.0;
 
static var apparentThrust: float;
 
static var hoverHeight : float = 15;
//var hoverHeight2 = hoverHeight;
var springiness : float = 1;
var damping 	: float = 0.1;
static var thrust		: float = 75;  
var centerOfGravity	: Vector3;
var ground 	: Transform;
var gravity	: float = 9.8;
 
static var maxSteeringAngle = 30;  // variables added by bs
static var speed = 6.0;  //temporary only, just testing, bs
var smooth = 2.0; 
private var moveDirection = Vector3.zero; 
private var currentRotation : Quaternion; 
private var targetRotation : Quaternion;  //end of bs - add variables
 
 
var OneDGrav : boolean = true;
 
function Start()
{
	rigidbody.centerOfMass = centerOfGravity;
	if (rigidbody)    {       		//bs add
	rigidbody.freezeRotation = true;     //bs add
	} 												
}
 
 
	
	function Update () { 
		//var uThrust : float;
		
		//bs 4 lines here
		currentRotation = transform.rotation;    
		targetRotation = Quaternion.Euler(0,  Input.GetAxis("Horizontal") * maxSteeringAngle, 0);     
		currentRotation.eulerAngles.y += targetRotation.eulerAngles.y;     
		transform.rotation = Quaternion.Slerp(transform.rotation, currentRotation, Time.deltaTime * smooth); 
		
		if (Input.GetKey ("z")) {
		//hoverHeight = hoverHeight + 0.5;
		hoverHeight = hoverHeight + 0.5;
		}
        
		if (Input.GetKey ("x")) {
		//hoverHeight = hoverHeight - 0.5;
		hoverHeight = hoverHeight - 0.5;
		}
		
	}
	
 
function FixedUpdate () {
	
	 	var gravForce : Vector3 =  (ground.position - transform.position).normalized * gravity;
	 	if ( OneDGrav )
			rigidbody.AddForce(0, gravity, 0);
		else
			rigidbody.AddForce(gravForce);
		
		
	
		
	//	Get the four corners of the vehicle in world space.
		var frontLeft : Vector3 = transform.TransformPoint(-width / 2, -height / 2, length / 2);
		var frontRight : Vector3 = transform.TransformPoint(width / 2, -height / 2, length / 2);
		var backLeft : Vector3 = transform.TransformPoint(-width / 2, -height / 2, -length / 2);
		var backRight : Vector3 = transform.TransformPoint(width / 2, -height / 2, -length / 2);
		
	//	Vehicle's relative "up" direction.
		var relUp : Vector3 = transform.TransformDirection(Vector3.up);
		var frontLeftHit : RaycastHit;
		var frontRightHit : RaycastHit;
		var backLeftHit : RaycastHit;
		var backRightHit : RaycastHit;
		
	//	Measure the distance to the ground with rays.
		Physics.Raycast(frontLeft, -relUp, frontLeftHit);
		Physics.Raycast(frontRight, -relUp, frontRightHit);
		Physics.Raycast(backLeft, -relUp, backLeftHit);
		Physics.Raycast(backRight, -relUp, backRightHit);
	
	//	Get the current velocity of the corner points in the
	//	hover's up/down direction to act as damping for the
	//	springy hovering force.
		var dampVec = new Vector3(0, damping, 0);
		
		var frontLeftDamp : Vector3 = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(frontLeft)), dampVec));
		var frontRightDamp : Vector3 = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(frontRight)), dampVec));
		var backLeftDamp : Vector3 = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(backLeft)), dampVec));
		var backRightDamp : Vector3 = transform.TransformDirection(Vector3.Scale(transform.InverseTransformDirection(rigidbody.GetPointVelocity(backLeft)), dampVec));
 
 
		var frontLeftLift : Vector3 = (-relUp * gravity / 4) + (relUp * (hoverHeight - frontLeftHit.distance) * springiness) - frontLeftDamp;
		var frontRightLift : Vector3 = (-relUp * gravity / 4) + (relUp * (hoverHeight - frontRightHit.distance) * springiness) - frontRightDamp;
		var backLeftLift : Vector3 = (-relUp * gravity / 4) + (relUp * (hoverHeight - backLeftHit.distance) * springiness) - backLeftDamp;
		var backRightLift : Vector3 = (-relUp * gravity / 4) + (relUp * (hoverHeight - backRightHit.distance) * springiness) - backRightDamp;
		
	//	Calculate a simple forward thrust from the arrow keys.
		var lThrust : float;
		var rThrust : float;
				
		lThrust = rThrust = thrust * Input.GetAxis("Vertical");
		
		var horizAxis : float = Input.GetAxis("Horizontal");
		
		
		// bs try and capture lThrust for FuelDisplay.js calc
		
		apparentThrust = lThrust;
		
		//var turnMagic : float;
		moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));    
		moveDirection = transform.TransformDirection(moveDirection);    
		rigidbody.AddForce(moveDirection * speed);
		// bs out now...
		
		
var lThrustForce : Vector3 = transform.TransformDirection(Vector3.forward) * (lThrust + horizAxis);
var rThrustForce : Vector3 = transform.TransformDirection(Vector3.forward) * (rThrust - horizAxis);
		//var RightTurn
 
	//	Add the forces to the hover at the appropriate places. Note that
	//	the back corners have forward thrust as well as lift.
		rigidbody.AddForceAtPosition(frontLeftLift, frontLeft);
		rigidbody.AddForceAtPosition(frontRightLift, frontRight);
		rigidbody.AddForceAtPosition(backLeftLift + lThrustForce, backLeft);
		rigidbody.AddForceAtPosition(backRightLift + rThrustForce, backRight);
		
 
	
}