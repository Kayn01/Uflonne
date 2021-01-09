using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneTitle : MonoBehaviour
{
    //title card variables
    public bool needText;
    public string placeName;
    public GameObject text;
    public Text placeText;
    public Text UflonText;
    public InventoryItem Uflon;
    // Start is called before the first frame update
    void Start()
    {
        if (needText)
        {
            StartCoroutine(placeNameCo());
        }

        
    }

    // Update is called once per frame
    void Update()
    {

        UflonText.text = Uflon.numberHeld.ToString(); 
    }

    private IEnumerator placeNameCo()
    {
        text.SetActive(true);
        placeText.text = placeName;
        yield return new WaitForSeconds(4f);
        text.SetActive(false);
    }
}
