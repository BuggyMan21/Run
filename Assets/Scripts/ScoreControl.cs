using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] GameObject scoreBox;
    public static int totalScore = 0;
    

    // Update is called once per frame
    void Update()
    {
        scoreBox.GetComponent<TMPro.TMP_Text>().text = "Score: " + totalScore;
    }
}
