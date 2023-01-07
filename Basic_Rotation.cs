1. Local rotation: Local rotation is the rotation of an object relative to its parent object. You can use the Transform component's "Rotate" function to rotate an object locally, like this:

transform.Rotate(Vector3.up, 45f);

2. World rotation: World rotation is the rotation of an object relative to the world coordinate system. You can use the Transform component's "RotateAround" function to rotate an object around a point in the world, like this:

transform.RotateAround(Vector3.zero, Vector3.up, 45f);

3. Quaternion rotation: Quaternion rotation is a way of representing rotations using a four-dimensional vector called a quaternion. Quaternions can be used to rotate objects in a more stable and efficient way than Euler angles, and they are often used for character animations. You can use the Transform component's "Rotate" function to rotate an object using quaternions, like this:

//This will rotate the object 45 degrees around its local X axis.
transform.rotation = Quaternion.Euler(45f, 0f, 0f);

//if you want to add to the object's current rotation instead of replacing it, you can use the "RotateAround" function with quaternions like this:
transform.rotation *= Quaternion.Euler(45f, 0f, 0f);
