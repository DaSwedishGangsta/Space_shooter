using UnityEngine;

public class Astroid : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    [SerializeField]
    GameObject loseScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        loseScreen = FindFirstObjectByType<Canvas>().transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position -= new Vector3(0, 2, 0) * speed * Time.deltaTime;

        
        if (transform.position.y <= -5.6f)
        {
            print("You lost!");
            loseScreen.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
            //Application.Quit();
        }
    }
}
