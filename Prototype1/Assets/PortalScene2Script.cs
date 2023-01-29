using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PortalScene2Script : MonoBehaviour
{
   

    private void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Helllooo scen2");
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello: " + collider.gameObject);
            // DontDestroyOnLoad(text);
            //DontDestroyOnLoad(gameObject.GetComponent<Text>());
            //text = GameObject.Find("Text1").GetComponent<Text>();
            //text.text = "Amogha";
            //DontDestroyOnLoad(GameObject.Find("TimerTextTwo").GetComponent<Text>());
           
            SceneManager.LoadScene("SampleScene");
        }
    }
}
