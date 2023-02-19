using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    public float speed = 25.0f;
    private Rigidbody myRigid;
    public GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("Finish"))
        {
           Destroy(this.gameObject);
            myManager.GameOver();

            SceneManager.LoadScene("Scenes/test");
            Debug.Log("realod scene");

        }
    }
}
