using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameAdsController : MonoBehaviour
{
    [Header("Android Ads ID")] public string android_BannerUnitID = "ca-app-pub-3940256099942544/6300978111";
    public string android_InterstitialUnitID = "ca-app-pub-3940256099942544/1033173712";
    public string android_RewardUnitID = "ca-app-pub-3940256099942544/5224354917";


    [Header("iOS Ads ID")] [Space(15)] public string iOS_BannerUnitID = "ca-app-pub-3940256099942544/2934735716";
    public string iOS_InterstitialUnitID = "ca-app-pub-3940256099942544/4411468910";
    public string iOS_RewardUnitID = "ca-app-pub-3940256099942544/1712485313";

    [Header("Banner Ad Extra config")] [Space(15)]
    public bool banner_isEnable = true;

    public static GameAdsController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }


    #region Reward Video Ads

    public void CreateAndLoadRewardedAd()
    {
    }

    public void ShowRewardAds()
    {
    }

    #endregion Reward Video Ads

    public void Hidebanner()
    {
    }

    public void RequestInterstitial()
    {
    }

    public void ShowInterstitialAds()
    {
    }

    public void RequestBanner()
    {
    }

    public void Showbanner()
    {
    }
}