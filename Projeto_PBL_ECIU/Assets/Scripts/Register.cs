using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{

    public InputField username_input;
    public InputField gender_input;
    public InputField email_input;
    public InputField password_input;
    public InputField birthDate_input;
    public GameObject nextPage;
    public GameObject Loading;
    public Player_Prefs prefs;
    public string LogInState;

    public void Start()
    {
        Debug.Log(PlayerPrefs.GetString("userid"));
    }
    public void registo_auth()
    {
        LogInState = "Waiting";
        StopCoroutine("CheckState");
        StartCoroutine("CheckState");

        //Debug.Log("Registo realizado com sucesso");

        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        string username = username_input.text.ToString();
        string gender = gender_input.text.ToString();
        string email = email_input.text.ToString();
        string password = password_input.text.ToString();
        string birthDate = birthDate_input.text.ToString();


        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                LogInState = "NotDone";
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                LogInState = "NotDone";
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

          
            
            Firebase.Auth.FirebaseUser newUser = task.Result;
            DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

            User utilizador = new User(newUser.UserId, username, email, birthDate, gender);
            string json = JsonUtility.ToJson(utilizador);
            reference.Child("utilizadores").Child(newUser.UserId).SetRawJsonValueAsync(json);
            LogInState = "Done";
            prefs.SaveUserData(newUser.UserId, username, email, birthDate, gender, null);
            Debug.Log("Este é o log que queremos" + PlayerPrefs.GetString("userid"));
            
        });
        }




    IEnumerator CheckState()
    {

        for (; ; )
        {

            if (LogInState == "Done")
            {
                Loading.SetActive(false);
                Debug.Log("Done");
                gameObject.SetActive(false);
                SceneManager.LoadScene("Login");
                break;
            }
            if (LogInState == "NotDone")
            {
                Loading.SetActive(false);
                Debug.Log("Not Done");
                break;

            }

            if (LogInState == "Waiting")
            {
                Loading.SetActive(true);

                Debug.Log("Waiting");

            }


            yield return new WaitForSeconds(.1f);

        }


    }


}