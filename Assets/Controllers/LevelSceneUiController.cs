using TMPro;
using UnityEngine;

public class LevelSceneUiController : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] HPComponent hpComponent;
    [SerializeField] TMP_Text scoreText;

    public static LevelSceneUiController Instance;

    private int scoreCount;

    public int ScoreCount
    {
        get { return scoreCount; }
        set 
        { 
            scoreCount = value;
            scoreText.text = $"Pontos: {scoreCount}";
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        playerName.text = "Flavio teste";
    }

    public void TakeDamage()
    {
        hpComponent.TakeDamage(3);
    }

    public float GetDamage() => hpComponent.GetDamage();
}
