using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scorer : MonoBehaviour
{
    public int minValue = 0; 
   public int maxValue = 5;

   public GameObject GameOverScreen;

   public GameObject DONE;

    [SerializeField] public TextMeshProUGUI Health;
    [SerializeField] private int _hits = 7;

  
   //   void OnCollisionEnter(Collision other)
  //  {
  //          minValue = 0;
       //     maxValue = 3;
    //    if(other.gameObject.CompareTag("Obstacle"))
       // {

        //   maxValue =;
      //     Health.text = maxValue.ToString();
      //  }
   // }
        private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
                _hits--;
                Health.text = "Health: " + _hits.ToString();
        }    

        if(_hits <= 0)
        {
            GameOverScreen.gameObject.SetActive(true);
        }
        
                if(other.gameObject.CompareTag("FIN"))
                {
                DONE.gameObject.SetActive(true);
                }
 
    }

}