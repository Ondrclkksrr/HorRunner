using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField isimalani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void basla()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetString("Name", isimalani.text);

    }
}

