using UnityEngine;
using UnityEngine.UI;

public class HPComponent : MonoBehaviour
{
    [SerializeField] Slider hpBar;

    public void TakeDamage(int damage)
    {
        hpBar.value -= damage;
    }

    public void RecoverLife(int amount)
    {
        hpBar.value += amount;
    }

    public float GetDamage() => hpBar.value;
}