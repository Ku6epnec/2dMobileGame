using Profile;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] 
    private Transform _placeForUi;

    [SerializeField]
    private UnityAdsTools _unityAdsTools;

    private MainController _mainController;

    private void Start()
    {
        var profilePlayer = new ProfilePlayer(15f);
        profilePlayer.CurrentState.Value = GameState.Start;
        _mainController = new MainController(_placeForUi, profilePlayer);
        _unityAdsTools.ShowRewardVideo();
    }

    protected void OnDestroy()
    {
        _mainController?.Dispose();
    }
}
