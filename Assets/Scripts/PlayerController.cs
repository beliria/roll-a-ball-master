using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed = 0.0f;
    int score;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        myRigidbody.AddForce (movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Comparo el tag del objeto contra el que he colisionado, para desactivarlo solo en el caso de que sea un pickup
        if (other.gameObject.CompareTag("Pickup"))
        { 
            //Si es un pickup, lo desactivo
            other.gameObject.SetActive(false);

            score += other.gameObject.GetComponent<Pickup>().coins;
            scoreText.text = "score: " + score;
        }
    }
}
