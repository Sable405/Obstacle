using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NextOne : MonoBehaviour
{
    // Start is called before the first frame update
    public void Next()
    {
        SceneManager.LoadScene(1);
    }
        public void Next5()
    {
        SceneManager.LoadScene(0);
    }
            public void Next6()
    {
        SceneManager.LoadScene(3);
    }
            public void Next7()
    {
        SceneManager.LoadScene(4);
    }
                public void Startt()
    {
        SceneManager.LoadScene(5);
    }
                    public void Info()
    {
        SceneManager.LoadScene(6);
    }
}
