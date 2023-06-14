using UnityEngine;

public class SwitchColorHero : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Hero;

    public void SwitchColorYellow()
    {
        Hero.color = Color.yellow;
    }
    public void SwitchColorWhite()
    {
        Hero.color = Color.white;
    }
}
