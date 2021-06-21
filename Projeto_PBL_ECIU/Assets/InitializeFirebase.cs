using UnityEngine;
using Firebase;
using Firebase.Analytics;

public class InitializeFirebase : MonoBehaviour
{
    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

 
}
