// 1. transform.Translate
public float speed = 2;
void Update()
{
    // Moves the object forward at two units per second.
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
}
