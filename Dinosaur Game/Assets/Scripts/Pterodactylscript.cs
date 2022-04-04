using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pterodactylscript : MonoBehaviour
{
    public PterodactylGenerator pterodactylGenerator;

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * pterodactylGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            
            pterodactylGenerator.GenerateNextPterodactyl();

        }

        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);

        }
        
    }
}
