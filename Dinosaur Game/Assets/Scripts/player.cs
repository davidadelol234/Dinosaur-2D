using UnityEngine;
using UnityEngine.UI;
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

        if(isAlive)
        {
            score += Time.deltaTime * 4;
            ScoreText.text = "SCORE : " + score.ToString("F");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if(collision.gameObject.CompareTag("block"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }
}
