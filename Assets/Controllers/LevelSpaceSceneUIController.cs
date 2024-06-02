using TMPro;
using UnityEngine;

public class LevelSpaceSceneUIController : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] HPComponent hpComponent;
    [SerializeField] TMP_Text scoreText;

    public static LevelSpaceSceneUIController Instance;

    private int scoreCount = 0;

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
        hpComponent.TakeDamage(10);
    }

    public float GetDamage() => hpComponent.GetDamage();
}
