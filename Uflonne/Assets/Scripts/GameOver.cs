using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject BoatDialogue;
    public InventoryItem Uflon;
    public Text warning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesClick()
    {
        if(Uflon.numberHeld >= 5)
        {
            SceneManager.LoadScene("Ending");
        }
        else
        {
            warning.text = "jumlah Uflon belum 5";
        }
    }

    public void NoClick()
    {
        BoatDialogue.SetActive(false);
        warning.text = "(dapat kembali apabila memiliki 5 uflon)";
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
