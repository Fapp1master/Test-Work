using UnityEngine;

public class DisplacementItem : MonoBehaviour
{
    public float n;
    [SerializeField] private SwitchColorHero switchColorHero;
    [SerializeField] private Transform teleportPoint;
    [SerializeField] private Transform item;
    private float distanceBetween;

    private void Update()
    {
        TeleportItem();
    }
    private void CalculatingWithDistance()
    {
        distanceBetween = Vector2.Distance(transform.position, item.position);
    }
    private void TeleportItem()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            switchColorHero.SwitchColorYellow();
            Debug.Log("Yellow");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            CalculatingWithDistance();
            switchColorHero.SwitchColorWhite();
            if (distanceBetween > n)
            {
                item.position = teleportPoint.position;
            }

        }
    }

}

