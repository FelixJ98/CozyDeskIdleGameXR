using UnityEngine;

public class GivebackGrav : MonoBehaviour
{ 
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private Transform spawnPoint;

    public void SpawnObject1()
    {
        SpawnPrefab(prefab1);
    }
    
    public void SpawnObject2()
    {
        SpawnPrefab(prefab2);
    }
    
    private void SpawnPrefab(GameObject prefabToSpawn)
    {
        GameObject newObject = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
        newObject.transform.SetParent(null);
        
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }
    }
}