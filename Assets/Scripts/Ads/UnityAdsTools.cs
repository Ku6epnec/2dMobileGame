using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsTools : MonoBehaviour, IAdsShower, IUnityAdsListener
{
    private const string _gameId = "4165993";
    private const string _rewardPlacementID = "rewardedVideo";
    private const string _bannerPlacementID = "Banner";
    private void Start()
    {
        Advertisement.Initialize(_gameId, true);
    }

    public void ShowBannerVideo()
    {
        Advertisement.Show(_rewardPlacementID);
    }

    public void ShowRewardVideo()
    {
        Advertisement.Show(_bannerPlacementID);
    }

    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        throw new System.NotImplementedException();
    }
}
