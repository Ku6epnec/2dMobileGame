using UnityEngine;

public class CarController : BaseController
{
    private readonly ResourcePath _viewPath = new ResourcePath {PathResource = "Prefabs/Car"};
    private readonly CarView _carView;

    public CarController()
    {
        _carView = LoadView();
    }

    private CarView LoadView()
    {
        var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
        AddGameObjects(objView);
        
        return objView.GetComponent<CarView>();
    }

    public GameObject GetViewObject()
    {
        return _carView.gameObject;
    }
}

