// 1. move an object
public float speed = 2;
void Update()
{
    // Moves the object forward at two units per second.
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
}

// 2. move an object with the keyboard
public float speed = 2;
void Update()
{
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(x, 0, z);
    transform.Translate(movement * speed * Time.deltaTime);
}

// 2. Even movement controls with Clamp Magnitude
public float speed = 2;
void Update()
{
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(x, 0, z);
    // This will limit the length of the vector to one, while leaving lower values intact, allowing you to create analogue 8-way movement that’s even in all directions.
    movement = Vector3.ClampMagnitude(movement, 1);
    transform.Translate(movement * speed * Time.deltaTime);
}

//3.move an object to a position in a set time (using Lerp)
// Lerp, or Linear Interpolation —— This can be used to change a colour, fade an audio source or move an object between two points.
float lerpedValue = Mathf.Lerp(float minValue, float maxValue, float t);

// it’s also possible to smooth the Lerp’s movement using the Smooth Step function.
float t = Mathf.SmoothStep(0, 1, timeElapsed / moveDuration);

//4. move an object using physics
public Rigidbody rb;
public float forceAmount = 10;
void FixedUpdate()
{
    rb.AddForce(Vector3.up * forceAmount);
}

public Rigidbody rb;
public float forceAmount = 10;
void Start()
{
    rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
}

// Look At
public Transform target;
    
void Update ()
{
    transform.LookAt(target);
}
