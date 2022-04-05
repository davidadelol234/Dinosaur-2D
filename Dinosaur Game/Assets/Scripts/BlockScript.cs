using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    public BlockGenerator blockGenerator;
    

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * blockGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            blockGenerator.GeneratNextBlock();
            

        }

        if(collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Destroy block");
            Destroy(this.gameObject);

        }
        
    }
}
