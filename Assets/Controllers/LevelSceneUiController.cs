using TMPro;
using UnityEngine;

public class LevelSceneUiController : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] HPComponent hpComponent;
    [SerializeField] TMP_Text scoreText;

    public static LevelSceneUiController Instance;

    int scoreCount;

    public int ScoreCount
    {
        get { return scoreCount; }
        set
        {
            scoreCount = value;
            scoreText.text = $"Pontos: {scoreCount}";
        }
    }

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        playerName.text = PlayerPrefs.GetString("userName");
    }

    public void TakeDamage()
    {
        hpComponent.TakeDamage(3);
    }

    public float GetDamage() => hpComponent.GetDamage();
}