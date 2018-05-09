using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Leaderboards : MonoBehaviour {

    public Text ScoreText;
    string getUrl = "https://student.sps-prosek.cz/~milando15/GalaxyOdyssey/CloudScripts/GetData.php";
    string postUrl = "https://student.sps-prosek.cz/~milando15/GalaxyOdyssey/CloudScripts/PostData.php?";

	// Use this for initialization
	void Start () {
        //StartCoroutine(GetScore());
        //StartCoroutine(PostScore());
	}
	
	// Update is called once per frame
	void Update () {
        //GetScore();
	}

    IEnumerator PostScore()
    {
        string post = postUrl + "nickname=" + "Nickname" + "&score=" + ScoreHandler.Score;
        WWW hs_post = new WWW(post);
        yield return hs_post;

        if(hs_post.error != null)
        {
            print("Error" + hs_post.error);
        }
    }

    IEnumerator GetScore()
    {
        WWW hs_get = new WWW(getUrl);
        yield return hs_get;

        if(hs_get.error != null)
        {
            ScoreText.text = "There was an error: " + hs_get.error;
        }
        else
        {
            ScoreText.text = hs_get.text;
        }
    }
}
