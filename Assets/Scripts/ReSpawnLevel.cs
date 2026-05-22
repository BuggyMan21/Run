using UnityEngine;
using UnityEngine.SceneManagement;

public class ReSpawnLevel : MonoBehaviour
{
    void Start()
    {
        ScoreControl.totalScore = 0;
        SceneManager.LoadScene(LevelMaintain.LevelNumber);
    }

    
}
