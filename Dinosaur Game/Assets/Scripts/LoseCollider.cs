using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
       Debug.Log("Collision detected");
       Debug.Log(collision.transform.position);
       if (collision.gameObject.CompareTag("nextLine")){

       } else{
       SceneManager.LoadScene("Game Over");
       }
   }
}
