using Profile;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] 
    private Transform _placeForUi;

    private MainController _mainController;

    private void Awake()
    {
        var profilePlayer = new ProfilePlayer(15f);
        profilePlayer.CurrentState.Value = GameState.Start;
        _mainController = new MainController(_placeForUi, profilePlayer);
    }

    protected void OnDestroy()
    {
        _mainController?.Dispose();
    }
}
