// Link https://learn.unity.com/tutorial/intro-to-the-unity-physics-engine-2019-3?language=en#5f7cefdbedbc2a00243033ec

1. Rigidbody physics: Rigidbody physics allows you to add realistic physical behavior to your game objects. You can use the Rigidbody component to apply forces and torque to objects, and they will respond according to the laws of physics (e.g., an object with a higher mass will be harder to move than an object with a lower mass).
2. Collision detection: Unity's physics engine includes collision detection functionality, which allows you to detect when two collider-equipped objects collide. You can use this to trigger events or apply damage to objects in your game.
3. Raycasting: Raycasting is a technique for detecting objects in the scene by casting a "ray" from a starting point in a particular direction. You can use raycasting to detect objects that are in the line of sight of a camera, or to find the point at which a ray intersects with a collider.
4. Ragdoll physics: Ragdoll physics allows you to create realistic, physics-based character animations by setting up a hierarchy of rigidbody components and constraining them together with joints. When you apply forces to a character with a ragdoll setup, the individual body parts will move and collide with other objects according to the laws of physics.


    // 1.Character control
    using UnityEngine;

    public class ApplyForce : MonoBehaviour
    {
        public float force = 10.0f;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
            }
        }
    }

    rigidbody = GetComponent<Rigidbody>();
    rigidbody.AddForce(RandomForce(), ForceMode.Impulse);
    rigidbody.AddTorque(RandomTorque(), ForceMode.Impulse);
    
    // Preventing camera jitter
    // Apply forces in FixedUpdate and apply camera movements in LateUpdate, instead of putting both in the Update method.


// 3.Collision

// 4.Joints

// 5.Cloth

// Raycast
