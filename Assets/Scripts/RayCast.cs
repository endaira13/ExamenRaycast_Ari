using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayCast : MonoBehaviour
{
    public Text FiveText;
    int Fivenumber;
    [SerializeField]private LayerMask ignoreLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;
        if(Physics.Raycast(ray, out rayHit))
        {
           Debug.Log(rayHit.transform.name);
           Fivenumber --;
           FiveText.text = Fivenumber.ToString();

           if(rayHit.transform.gameObject.tag == "Cubo1")
           {
            SceneManager.LoadScene("Scene1 1");
           }

           if(rayHit.transform.gameObject.tag == "Cubo2")
           {
            SceneManager.LoadScene("Scene1 2");
           }

           if(rayHit.transform.gameObject.tag == "Cubo3")
           {
            SceneManager.LoadScene("Scene1 3");
           }
            
            
        }
        

        
    }

}
