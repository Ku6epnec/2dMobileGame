using Tools;
using UnityEngine;

public class InputGameController : BaseController
{
    public InputGameController(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, Car car)
    {
        _view = LoadView();
        _view.Init(leftMove, rightMove, car.Speed);
    }

    private readonly ResourcePath _viewPath = new ResourcePath {PathResource = "Prefabs/endlessMove"};
    private BaseInputView _view;

    private BaseInputView LoadView()
    {
        var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
        AddGameObjects(objView);
        
        return objView.GetComponent<BaseInputView>();
    }
}

