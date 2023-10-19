using UnityEngine;

public static class Inputs
{
    private static PlayerControls _actions;
    private static PlayerScript _owner;
    

    public static void Init(PlayerScript player)
    {
        _actions = new PlayerControls();

        _owner = player;

        _actions.Player.Move.performed += ctx => _owner.Move(ctx.ReadValue<Vector2>());

        PlayMode();
    }

    public static void PlayMode()
    {
        _actions.Player.Enable();
    }

}
