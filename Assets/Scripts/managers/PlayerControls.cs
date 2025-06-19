using UnityEngine;

public static class PlayerControls
{
    private static GameControls _gameControls;
    private static Player _owner;

    public static void Initialize(Player player)
    {
        _owner = player;
        _gameControls = new GameControls();
        _gameControls.Player.Move.performed += ctx => _owner.SetMoveDirection(ctx.ReadValue<Vector2>());
    }

    public static void PlayMode()
    {
        _gameControls.Player.Enable();
    }
}
