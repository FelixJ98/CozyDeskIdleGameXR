using UnityEngine;
public class GivebackGrav : MonoBehaviour
{ 
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private Transform spawnPoint;
    public void SpawnObject1()
    {SpawnPrefab(prefab1);}
    public void SpawnObject2()
    {SpawnPrefab(prefab2);}
    private void SpawnPrefab(GameObject prefabToSpawn)
    {
        Vector3 worldPosition = spawnPoint.position;
        Quaternion worldRotation = spawnPoint.rotation;
        GameObject newObject = Instantiate(prefabToSpawn, worldPosition, worldRotation, null);
        Debug.Log("Spawned object: " + newObject.name);
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        Debug.Log("Rigidbody found: " + (rb != null));
        
        if (rb == null)
        {Debug.Log("Adding Rigidbody...");
         rb = newObject.AddComponent<Rigidbody>();
        }
        rb.isKinematic = true;
        rb.useGravity = false;
        Debug.Log("Rigidbody set to kinematic: " + rb.isKinematic);
    }
}