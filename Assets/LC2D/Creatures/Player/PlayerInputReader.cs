using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour
{
    [SerializeField] private Player player;

    public void OnMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        player.SetDirection(direction);
    }

    public void OnRunning(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            player.SetRun(true);
        }

        if (context.canceled)
        {
            player.SetRun(false);
        }
    }
}
