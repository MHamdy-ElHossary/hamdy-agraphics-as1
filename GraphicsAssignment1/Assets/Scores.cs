/*using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = OnGetText();
    }

    public void OnGetText()
    {
        text = RetrieveFromDatabase();
    }

    private Text RetrieveFromDatabase()
    {
        RestClient.Get<Text>("https://advanced-graphics-as1-default-rtdb.europe-west1.firebasedatabase.app/" + "Text1.json").Then(response =>
        {
            return response;
        });

        return null;
    }
}*/
