// Link https://learn.unity.com/tutorial/intro-to-the-unity-physics-engine-2019-3?language=en#5f7cefdbedbc2a00243033ec
// 1.Character control

// 2.Rigidbody physics
rigidbody = GetComponent<Rigidbody>();
rigidbody.AddForce(RandomForce(), ForceMode.Impulse);
rigidbody.AddTorque(RandomTorque(), ForceMode.Impulse);
// * Preventing camera jitter
Apply forces in FixedUpdate and apply camera movements in LateUpdate, instead of putting both in the Update method.


// 3.Collision

// 4.Joints

// 5.Cloth

// Raycast
