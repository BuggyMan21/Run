using UnityEngine;

public class LevelMaintain : MonoBehaviour
{
    public static int LevelNumber;
    [SerializeField] int internalNumber;
    void Start()
    {
       internalNumber = LevelNumber;
    }

   
}
