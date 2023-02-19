using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 30f;
    public float rightLimit = 4.5f;
    public float leftLimit = -4.5f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > leftLimit)
            {
                this.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < rightLimit)
            {
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            }

        }
    }
}
