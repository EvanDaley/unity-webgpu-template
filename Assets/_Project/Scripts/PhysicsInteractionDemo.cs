using UnityEngine;

public class PhysicsInteractionDemo : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public int objectCount = 10;
    public float spawnRange = 5f;

    void Start()
    {
        CreateObjects();
    }

    void CreateObjects()
    {
        for (int i = 0; i < objectCount; i++)
        {
            // Randomly choose between cube and sphere
            GameObject obj = Random.Range(0, 2) == 0 ? cubePrefab : spherePrefab;

            // Random position in the scene
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRange, spawnRange), 
                Random.Range(5f, 10f),  // Random height
                Random.Range(-spawnRange, spawnRange)
            );

            // Instantiate object and add Rigidbody for physics
            GameObject newObj = Instantiate(obj, spawnPosition, Quaternion.identity);
            newObj.AddComponent<Rigidbody>();  // Adds Rigidbody component to enable physics

            // Randomize object scale for some variation
            newObj.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);

            // Apply random color
            Renderer objRenderer = newObj.GetComponent<Renderer>();
            if (objRenderer != null)
            {
                objRenderer.material.color = GetRandomColor();
            }
        }
    }

    Color GetRandomColor()
    {
        // Generate random RGB values
        return new Color(Random.value, Random.value, Random.value);
    }
}
