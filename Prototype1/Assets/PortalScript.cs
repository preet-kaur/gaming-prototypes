using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalScript : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Helllooo");
        if (collider.gameObject.CompareTag("Player"))
        {
            //DontDestroyOnLoad(gameObject.GetComponent<Text>());
            Debug.Log("Hello: " + collider.gameObject);
            // Awake();
            //DontDestroyOnLoad(text);
            SceneManager.LoadScene("PortalScene2");
        }
    }


}
