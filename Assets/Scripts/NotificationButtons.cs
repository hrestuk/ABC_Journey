using UnityEngine;
using UnityEngine.UI;

public class NotificationButtons : MonoBehaviour
{
    [SerializeField] private Button notificationsEnable;
    [SerializeField] private Button notificationsDisable;
    [SerializeField] private Color enableColor; // C063FF
    [SerializeField] private Color disableColor; // DBDBDB
    private bool isSwitched = true;

    public void SwitchNotifications()
    {
        isSwitched = !isSwitched;
        UpdateButtonColors();
    }

    private void UpdateButtonColors()
    {
        if (isSwitched)
        {
            SetButtonColor(notificationsEnable, enableColor);
            SetButtonColor(notificationsDisable, disableColor);
        }
        else
        {
            SetButtonColor(notificationsEnable, disableColor);
            SetButtonColor(notificationsDisable, enableColor);
        }
    }

    private void SetButtonColor(Button button, Color color)
    {
        var colorBlock = button.colors;

        colorBlock.normalColor = color;
        colorBlock.highlightedColor = color;
        colorBlock.pressedColor = color;
        colorBlock.selectedColor = color;

        button.colors = colorBlock;
    }
}
