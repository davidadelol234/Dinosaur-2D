using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{

    public float Jump;
    float score;

    [SerializeField] bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreText;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * Jump);
                isGrounded = false;
            }
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * Jump);
                isGrounded = false;
            }
        }

        if(isAlive)
        {
            score += Time.deltaTime * 4;
            //Debug.Log(score);
            ScoreText.text = "SCORE : " + score.ToString("F");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("SHOULD collide with block");

        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if(collision.gameObject.CompareTag("block"))
        {
            Debug.Log("collided with block");
            isAlive = false;
            Time.timeScale = 0;
            SceneManager.LoadScene("Game Over");
        }
        else if(collision.gameObject.CompareTag("pterodactyl"))
        {
            Debug.Log("collided with block");
            isAlive = false;
            Time.timeScale = 0;
            SceneManager.LoadScene("Game Over");
        }
    }
}
