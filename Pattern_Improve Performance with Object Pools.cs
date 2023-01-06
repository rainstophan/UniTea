using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // The prefab to pool
    public int initialPoolSize = 10; // The initial size of the pool
    public bool canGrow = true; // Whether the pool can grow if it runs out of objects

    private List<GameObject> pooledObjects; // The list of pooled objects

    void Start()
    {
        // Initialize the object pool
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < initialPoolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    // Get an object from the pool
    public GameObject GetObject()
    {
        // Look for an inactive object in the pool
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // If there are no inactive objects and the pool can grow, create a new object
        if (canGrow)
        {
            GameObject obj = Instantiate(prefab);
            pooledObjects.Add(obj);
    // If there are no inactive objects and the pool cannot grow, return null
    return null;
}

// Return an object to the pool
public void ReturnObject(GameObject obj)
{
    obj.SetActive(false);
}
