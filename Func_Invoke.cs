// Case 1
void Start()
{
    InvokeRepeating("SpawnObject", 1, 1);
}

void SpawnObject()
{
    float x = Random.Range(-2.0f, 2.0f);
    float z = Random.Range(-2.0f, 2.0f);
    Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
}


// Case 2
// Yes, Start can be an IEnumertaor and is in this case internally implicitly started as Coroutine!

IEnumerator Start() 
{
    while(true)
    {
        yield return new WaitForSeconds(1f);

        SpawnObject();
    }
}

// Case 3 FixedUpdate for physics
void Start()
{
    timer = 1f;
}

void Update()
{
    timer -= Time.deltaTime;
    if(timer < 0)
    {
        timer = 1f;
        SpawnObject();
     }
}
