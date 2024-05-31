using TMPro;
using UnityEngine;

public class LevelSceneUiController : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;

    void Start()
    {
        playerName.text = "Flavio teste";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
