using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;
    [SerializeField]
    KeyCode right = KeyCode.D;
    [SerializeField]
    KeyCode left = KeyCode.A;

    [SerializeField]
    KeyCode fire = KeyCode.Space;

    [SerializeField]
    GameObject Bullet;

    public int ammo = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else if (Input.GetKey(left))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(fire) && ammo > 0)
        {
            Instantiate(Bullet,transform.position,Quaternion.identity);
            ammo -= 1;
        }

        transform.position =
            new Vector3(Mathf.Clamp(transform.position.x, -10.5f, 10.5f),
            Mathf.Clamp(transform.position.y, -3.3f, 3.3f), 0);
    }
}