using UnityEngine;
using Firebase;
using Firebase.Analytics;

public class InitializeFirebase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

 
}
