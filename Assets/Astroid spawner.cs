using UnityEngine;

public class Astroidspawner : MonoBehaviour
{
    public float threshold;
    public float elapsedTime;

    [SerializeField]
    GameObject astroid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        elapsedTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime += Time.deltaTime;

        if (elapsedTime > threshold)
        {
            Debug.Log("New astroid!");
            // Do what you want
            Instantiate(astroid, transform.position + new Vector3(Random.Range(-10.4f, 10.4f), 0, 0), Quaternion.identity);
            elapsedTime = 0;
        }
    }
}
