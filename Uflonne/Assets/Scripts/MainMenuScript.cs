using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public InventoryItem Uflon;
    public InventoryItem Uflon1;
    public InventoryItem Uflon2;
    public InventoryItem Uflon3;
    public InventoryItem Uflon4;
    public InventoryItem Uflon5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPlayClicked()
    {

        SceneManager.LoadScene("MainCave");
        Uflon.numberHeld = 0;
        Uflon1.destroyed = false;
        Uflon2.destroyed = false;
        Uflon3.destroyed = false;
        Uflon4.destroyed = false;
        Uflon5.destroyed = false;

    }

    public void ExitClicked()
    {
        Application.Quit();
    }
}
