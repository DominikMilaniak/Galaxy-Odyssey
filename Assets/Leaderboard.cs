using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {

    public RectTransform myPanel;
    public GameObject myTextPrefab;
    public string[] highscoreList;
    string getUrl = "https://student.sps-prosek.cz/~milando15/GalaxyOdyssey/CloudScripts/Leaderboard.php";


    private GameObject newText;

	// Use this for initialization
	void Start () {
        StartCoroutine(GetHighscores());
    }
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator GetHighscores()
    {
        WWW hs_get = new WWW(getUrl);
        yield return hs_get;

        highscoreList = hs_get.text.Split('|');

        foreach (string value in highscoreList)
        {
            GameObject newText = (GameObject)Instantiate(myTextPrefab);
            newText.transform.SetParent(myPanel);
            newText.GetComponent<Text>().text = value;
        }
    }
}
