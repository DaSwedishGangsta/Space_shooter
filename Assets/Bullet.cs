using UnityEditor.EditorTools;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    PointManager Point;
    [SerializeField]
    float speed = 3f;

    Spaceship spaceship;

    private void Start()
    {
        spaceship = FindFirstObjectByType<Spaceship>();
    }

    private void Update()
    {
        transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        if (transform.position.y > 5.6f)
        {
            spaceship.ammo += 1;
            Destroy(gameObject);
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "astroid")
        {
            print("träff");
            spaceship.ammo += 1;
            //ge 1 poäng
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
